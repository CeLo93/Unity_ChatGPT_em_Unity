using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using System;

public class DiscussionBubble : MonoBehaviour
{
    [Header(" Elements ")]
    [SerializeField] private TextMeshProUGUI messageText; // Texto da mensagem exibida na bolha
    [SerializeField] private Image bubbleImage; // Imagem de fundo da bolha
    [SerializeField] private Sprite userBubbleSprite; // Sprite da bolha do usuário
    // [SerializeField] private GameObject voiceButton;

    [Header(" Settings ")]
    [SerializeField] private Color userBubbleColor; // Cor da bolha do usuário

    [Header(" Events ")]
    public static Action<string> onVoiceButtonClicked; // Evento disparado quando o botão de voz é clicado

    //! Configura a bolha de discussão com a mensagem e define se é do usuário ou não
    public void Configure(string message, bool isUserMessage)
    {
        if (isUserMessage)
        {
            bubbleImage.sprite = userBubbleSprite; // Configura a bolha como sendo do usuário
            bubbleImage.color = userBubbleColor; // Define a cor da bolha do usuário
            messageText.color = Color.white; // Define a cor do texto como branco

            //voiceButton.SetActive(false); // Desativa o botão de voz
        }

        messageText.text = message; // Define o texto da mensagem na bolha
        messageText.ForceMeshUpdate(); // Força a atualização do texto para evitar problemas de layout
    }

    //! Callback do botão de voz (comentado)
    public void VoiceButtonCallback()
    {
        onVoiceButtonClicked?.Invoke(messageText.text); // Dispara o evento onVoiceButtonClicked passando o texto da mensagem como argumento
    }

    //! Callback para copiar o texto para a área de transferência
    public void CopyToClipboardCallback()
    {
        GUIUtility.systemCopyBuffer = messageText.text; // Copia o texto da mensagem para a área de transferência do sistema
    }
}
