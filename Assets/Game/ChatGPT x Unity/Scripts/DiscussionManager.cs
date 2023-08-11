using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using OpenAI;
using OpenAI.Chat;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using UnityEngine.Networking;




public class DiscussionManager : MonoBehaviour
{
    [Header(" Elements ")]
    [SerializeField] private DiscussionBubble bubblePrefab; // Prefab da bolha de discussão

    [SerializeField] private TMP_InputField inputField; // Campo de entrada de texto para o usuário
    [SerializeField] private Transform bubblesParent; // Pai das bolhas de discussão

    [Header(" Events ")]
    public static Action onMessageReceived; // Evento disparado quando uma nova mensagem é recebida

    public static Action<string> onChatGPTMessageReceived; // Evento disparado quando uma nova mensagem do ChatGPT é recebida

    [Header(" Authentication ")]
    [SerializeField] private string[] apiKey; // Chave de API para autenticação
    [SerializeField] private string[] organizationId; // ID da organização e Cliente da API do OpenAI
    private OpenAIClient api;

    [Header(" Settings ")]
    [SerializeField] private List<ChatPrompt> chatPrompts = new List<ChatPrompt>(); // Lista de prompts de chat

    private void Start()
    {
        CreateBubble("Hey There ! How can I help you ?", false); // Cria uma bolha de discussão inicial

        Authenticate(); // Autentica o cliente da API

        Initiliaze(); // Inicializa os prompts de chat
    }

    private void Update()
    {
    }

    //! Autentica o cliente da API com a chave de API e ID da organização
    private void Authenticate()
    {
        api = new OpenAIClient(new OpenAIAuthentication(apiKey[0], organizationId[0]));
    }

    //! Inicializa os prompts de chat
    private void Initiliaze()
    {
        ChatPrompt prompt = new ChatPrompt("system", "You are a the best comedian in the world."); // Prompt de chat inicial
        chatPrompts.Add(prompt); // Adiciona o prompt à lista de prompts de chat
    }

    //! Callback para o botão de envio de mensagem
    public async void AskButtonCallback()
    {
        CreateBubble(inputField.text, true); // Cria uma bolha de discussão para a mensagem do usuário

        ChatPrompt prompt = new ChatPrompt("user", inputField.text); // Cria um prompt de chat com a mensagem do usuário
        chatPrompts.Add(prompt); // Adiciona o prompt à lista de prompts de chat

        inputField.text = ""; // Limpa o campo de entrada de texto

        ChatRequest request = new ChatRequest(
            messages: chatPrompts,
            model: OpenAI.Models.Model.GPT3_5_Turbo, // Modelo de chat usado (neste caso, GPT3.5 Turbo)
            temperature: 0.2); // Temperatura para geração de respostas

        try
        {
            var result = await api.ChatEndpoint.GetCompletionAsync(request); // Aguardar a resposta da API

            ChatPrompt chatResult = new ChatPrompt("system", result.Choices[0].Message.Content); // Cria um prompt de chat com a resposta do ChatGPT
            chatPrompts.Add(chatResult); // Adiciona o prompt à lista de prompts de chat

            onChatGPTMessageReceived?.Invoke(result.Choices[0].Message.Content); // Dispara o evento de nova mensagem do ChatGPT

            CreateBubble(result.Choices[0].Message.Content, false); // Cria uma bolha de discussão para a resposta do ChatGPT

            // Grava a conversa em um arquivo
            await GravarConversaEmArquivo(chatPrompts);
        }
        catch (Exception e)
        {
            Debug.Log(e); // Exibe qualquer exceção ocorrida durante a solicitação de chat
        }
    }

    //! Cria uma bolha de discussão com a mensagem especificada
    private void CreateBubble(string message, bool isUserMessage)
    {
        DiscussionBubble discussionBubble = Instantiate(bubblePrefab, bubblesParent); // Instancia uma bolha de discussão a partir do prefab
        discussionBubble.Configure(message, isUserMessage); // Configura a mensagem da bolha de discussão

        onMessageReceived?.Invoke(); // Dispara o evento de nova mensagem recebida
    }

    // Grava a conversa em um arquivo JSON
    private async Task GravarConversaEmArquivo(List<ChatPrompt> conversa)
    {
        try
        {
            // Serializa a conversa em formato JSON
            string conversaJson = JsonConvert.SerializeObject(conversa);

            // Caminho do arquivo
            string caminhoArquivo = Path.Combine(Application.persistentDataPath, "conversa.json");

            // Grava o JSON no arquivo
            File.WriteAllText(caminhoArquivo, conversaJson);

            Debug.Log("Conversa gravada em arquivo: " + caminhoArquivo);
        }
        catch (Exception e)
        {
            Debug.LogError("Erro ao gravar conversa em arquivo: " + e);
        }
    }
}
