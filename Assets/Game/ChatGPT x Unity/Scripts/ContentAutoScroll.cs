using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContentAutoScroll : MonoBehaviour
{
    private RectTransform rt;

    void Start()
    {
        rt = GetComponent<RectTransform>();

        DiscussionManager.onMessageReceived += DelayScrollDown; // Inscreve-se no evento onMessageReceived do DiscussionManager para iniciar a rolagem automática
    }

    private void OnDestroy()
    {
        DiscussionManager.onMessageReceived -= DelayScrollDown; // Remove a inscrição no evento onMessageReceived do DiscussionManager ao destruir este objeto
    }

    void Update()
    {
    }

    private void DelayScrollDown()
    {
        Invoke("ScrollDown", .3f); // Chama a função ScrollDown com um pequeno atraso para permitir a atualização correta da interface
    }

    private void ScrollDown()
    {
        Vector2 anchoredPosition = rt.anchoredPosition; // Obtém a posição ancorada atual do RectTransform
        anchoredPosition.y = Mathf.Max(0, rt.sizeDelta.y); // Define a posição ancorada para rolar o conteúdo para baixo
        rt.anchoredPosition = anchoredPosition; // Atualiza a posição ancorada do RectTransform para iniciar a rolagem automática
    }
}
