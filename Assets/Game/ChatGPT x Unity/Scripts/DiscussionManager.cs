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
    [SerializeField] private DiscussionBubble bubblePrefab;
    [SerializeField] private TMP_InputField inputField;
    [SerializeField] private Transform bubblesParent;

    [Header(" Events ")]
    public static Action onMessageReceived;
    public static Action<string> onChatGPTMessageReceived;

    [Header(" Authentication ")]
    [SerializeField] private string[] apiKey;
    [SerializeField] private string[] organizationId;
    private OpenAIClient api;

    [Header(" Settings ")]
    [SerializeField] private List<ChatPrompt> chatPrompts = new List<ChatPrompt>();

    private async void Start()
    {
        await InitializeChat();
        CreateBubble("Olá! Me diga o que está sentindo hoje!", false);
    }

    private async Task InitializeChat()
    {
        try
        {
            Authenticate();
            await LoadChatHistory(); // Carrega o histórico de conversas existentes
            await InitializePrompts();
        }
        catch (Exception e)
        {
            Debug.LogError($"Erro na inicialização do chat: {e}");
        }
    }

    private async Task LoadChatHistory()
    {
        try
        {
            string subfolder = "Conversas";
            string jsonFileName = "conversa.json";
            string subfolderPath = Path.Combine(Application.dataPath, subfolder);
            string jsonFilePath = Path.Combine(subfolderPath, jsonFileName);

            if (File.Exists(jsonFilePath))
            {
                string chatJson = File.ReadAllText(jsonFilePath);
                chatPrompts = JsonConvert.DeserializeObject<List<ChatPrompt>>(chatJson);

                // Remove a primeira fala do chat se ela for igual à mensagem inicial
                if (chatPrompts.Count > 0 && chatPrompts[0].Content == "Oi! Sou o seu amigável assistente virtual! Estou aqui para te ajudar com qualquer pergunta ou conversa que você queira ter. Vamos nos divertir e aprender juntos, meu amigo! 😄🌈🚀")
                {
                    chatPrompts.RemoveAt(0);
                }
            }

            Debug.Log("Histórico de conversas carregado com sucesso.");
        }
        catch (Exception e)
        {
            Debug.LogError($"Erro ao carregar histórico de conversas: {e}");
        }
    }

    private void Authenticate()
    {
        api = new OpenAIClient(new OpenAIAuthentication(apiKey[0], organizationId[0]));
    }

    private async Task InitializePrompts()
    {
        try
        {
            // Prompt de chat inicial
            string initialPromptContent = "Oi! Sou o seu amigável assistente virtual! " +
                "Estou aqui para te ajudar com qualquer pergunta ou conversa que você queira ter. " +
                "Vamos nos divertir e aprender juntos, meu amigo!";

            // Se você precisa inicializar o chat com uma mensagem do sistema
            ChatPrompt systemPrompt = new ChatPrompt("system", initialPromptContent);
            chatPrompts.Add(systemPrompt);

            // Aqui você pode adicionar mais prompts se necessário

            Debug.Log("Chat inicializado com sucesso.");
        }
        catch (Exception e)
        {
            Debug.LogError($"Erro na inicialização dos prompts de chat: {e}");
        }
    }

    public async void AskButtonCallback()
    {
        // Lembre-se de tratar entradas vazias ou inválidas
        if (string.IsNullOrWhiteSpace(inputField.text))
            return;

        try
        {
            string userMessage = inputField.text;
            CreateBubble(userMessage, true);
            chatPrompts.Add(new ChatPrompt("user", userMessage));

            inputField.text = "";

            await ProcessAIResponse(); // Aguarda o processamento da resposta do AI
        }
        catch (Exception e)
        {
            Debug.LogError($"Erro ao interagir com o ChatGPT: {e}");
        }
    }

    private async Task ProcessAIResponse()
    {
        try
        {
            ChatRequest request = new ChatRequest(
                messages: chatPrompts,
                model: OpenAI.Models.Model.GPT3_5_Turbo,
                temperature: 0.2);

            var result = await api.ChatEndpoint.GetCompletionAsync(request);

            string aiResponse = result.Choices[0].Message.Content;
            AddAIResponseToChat(aiResponse);
            SaveChatToJson(chatPrompts); // Salva a conversa após receber resposta

            // Pode ser útil enviar a conversa para o S3 aqui, após salvar localmente
        }
        catch (Exception e)
        {
            Debug.LogError($"Erro ao interagir com o ChatGPT: {e}");
        }
    }

    private void CreateBubble(string message, bool isUserMessage)
    {
        DiscussionBubble discussionBubble = Instantiate(bubblePrefab, bubblesParent);
        discussionBubble.Configure(message, isUserMessage);
        onMessageReceived?.Invoke();
    }

    private void AddAIResponseToChat(string response)
    {
        chatPrompts.Add(new ChatPrompt("system", response));
        onChatGPTMessageReceived?.Invoke(response);
        CreateBubble(response, false);
    }

    private void SaveChatToJson(List<ChatPrompt> chat)
    {
        try
        {
            string subfolder = "Conversas";
            string jsonFileName = "conversa.json";
            string subfolderPath = Path.Combine(Application.dataPath, subfolder);

            if (!Directory.Exists(subfolderPath))
            {
                Directory.CreateDirectory(subfolderPath);
            }

            string jsonFilePath = Path.Combine(subfolderPath, jsonFileName);
            string chatJson = JsonConvert.SerializeObject(chat, Formatting.Indented); // Formatação do JSON
            File.WriteAllText(jsonFilePath, chatJson);
            Debug.Log($"Conversa gravada em arquivo: {jsonFilePath}");
        }
        catch (Exception e)
        {
            Debug.LogError($"Erro ao salvar conversa em arquivo JSON: {e}");
        }
    }
}
