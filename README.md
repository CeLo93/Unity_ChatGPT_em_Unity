<img align='left' src='https://github.com/CeLo93/CeLo93/assets/92175791/71e3914e-e9be-46ab-be9f-fe7df7312ef4.gif' width="170"> 

# *In Unity*

Bem-vindo(a) ao ChatGPT em Unity, um projeto incrível que resolvi iniciar, onde une a poderosa API do ChatGPT da OpenAI com uma interface de bate-papo divertida e envolvente feita em Unity, especialmente desenvolvida para adolescentes e crianças. 🤖💬


## 🌐 Socials <img align='center' src='https://user-images.githubusercontent.com/5713670/87202985-820dcb80-c2b6-11ea-9f56-7ec461c497c3.gif' width="40"> :


<a href="https://www.youtube.com/channel/UCvjn1p6Pny3f2StiLvwR2Cw" target="_blank"><img src="https://img.shields.io/badge/YouTube-FF0000?style=for-the-badge&logo=youtube&logoColor=white" target="_blank"></a>
<a href="https://instagram.com/m_brito93" target="_blank"><img src="https://img.shields.io/badge/-Instagram-%23E4405F?style=for-the-badge&logo=instagram&logoColor=white" target="_blank"></a>
<a href = "mailto:marcelobrito.py@gmail.com"><img src="https://img.shields.io/badge/Gmail-D14836?style=for-the-badge&logo=gmail&logoColor=white" target="_blank"></a>
<a href="https://www.linkedin.com/in/marcelo-brito-9a0523280/" target="_blank"><img src="https://img.shields.io/badge/-LinkedIn-%230077B5?style=for-the-badge&logo=linkedin&logoColor=white" target="_blank"></a>


---------

<div align="center">
 
![2](https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/1dc131c9-f11a-4a84-b09b-186b1cd1b7f2)

</div>



## Sobre o Projeto
Após um mês de dedicação nesse projeto, enfrentando alguns obstáculos ao longo do caminho (tipo a API da OpenAI bloqueando meu acesso sem motivo, sério?!), decidi não desistir e resolvi trocar de conta na OpenAI. E adivinha? O limite free para uso da API estava relacionado ao tempo de uso, não ao acesso em si. Ou seja, meu limite tinha estourado na conta antiga. Enfim, consegui utilizar uma nova chave disponível e um ID da organização gratuito também. 💪


Mas chega de drama, vamos falar sobre o app. A minha ideia era criar algo para dispositivos móveis, direcionado para o público jovem, onde eles pudessem reviver aquela sensação nostálgica de conversar com o mago Merlin no antigo prompt do Windows 98 (lembram disso? rsrs). E assim, nasceu esse projeto.  


<div align="center">
 
![mobileimgtela](https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/52f50fe4-072b-4ff8-b592-8649c2a482c3)


</div>

<div align="center">

 📸 Imagem 01 - Visão da tela em formato mobile 📸

</div>

------


https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/60e02cfa-b0ff-4efe-8b34-4e84f3dbf62a

<div align="center">

 🎬 Video 01 - App PlayMode 🎬

</div>

## Principais Recursos
Basicamente, o que eu quis fazer foi chamar a API da OpenAI, integrar o ChatGPT no projeto (a parte que me deu duas semanas de tristeza) e configurar uma interface de bate-papo legal. Até agora, consegui implementar grupos de layout horizontal e vertical, visualização de rolagem, botão integrado com toda a lógica, elementos de layout personalizáveis e até mesmo um ajustador de tamanho de conteúdo. Tem um monte de outras coisas também, mas essas são as principais. 😄🚀

Na próxima versão, estou planejando adicionar recursos de Text-To-Speech e Speech-To-Text ao projeto, utilizando o Oculus SDK. Além disso, quero implementar um recurso para salvar o histórico de todas as conversas que o usuário teve com o ChatGPT. Vai ficar ainda mais legal! 👍

Ah, e não menos importante, vamos falar sobre monetização. Como a API da OpenAI não é gratuita para fins comerciais (queria que fosse, mas né...), estou pensando em usar o Activity Manager para rastrear a atividade do usuário. Depois de um certo número de interações no chat, eles terão que assistir a um vídeo ou assinar o serviço para remover os anúncios. Eu queria deixar tudo de graça, mas a vida é assim, precisamos nos sustentar. Para facilitar a monetização, vou integrar o novo sistema de Mediação de Anúncios da Unity. 💰💡



https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/31891eb8-7400-4cb6-a3fd-38d371d44223


<div align="center">

 🎬 Video 02 - Scroll da tela e conversa 🎬

</div>

## Boas Práticas e Desafios
No script do projeto, estou seguindo boas práticas de programação (a gente tenta, né?! rsrs). Uso coisas legais como actions, unity events, headers e tudo mais. Eu sei, poderia comentar mais o código, mas fiz o meu melhor, juro! 😉💻

A maior dificuldade que enfrentei foi elaborar o Callback para o botão de envio de mensagem. Sinceramente, sem a ajuda do ChatGPT, eu não sairia do lugar nesse ponto. Nessa parte do código, o programa está se comunicando com o ChatGPT, que é o modelo de linguagem  capaz de gerar respostas com base em um contexto fornecido. A função GetCompletionAsync é responsável por enviar uma solicitação para o ChatGPT, contendo as mensagens anteriores da conversa e outros parâmetros relevantes, como o modelo a ser utilizado e a temperatura de geração das respostas. Quanto às respostas um tanto "humorísticas", ainda não descobri o motivo, mas talvez o algoritmo esteja aprendendo e se adaptando ao estilo de cada usuário. Vou ver como ele se comporta com mais testes em outras chaves ou contas (vou precisar de mais números de celular para cadastro, caso use mais contas, rsrsrs!). 😄💬


Depois de enviar a solicitação, o programa fica aguardando a resposta do ChatGPT, que é recebida assincronamente (isso significa que, ao marcar a função como async e usar o await, o programa continua executando outras tarefas enquanto espera pela resposta da API. Nada de ficar travado!). Em seguida, tratamos a resposta e a exibimos ao usuário, geralmente em uma bolha de discussão. Essa interação de enviar uma mensagem, obter uma resposta e mostrá-la ao usuário é bem parecida com o processo de fazer uma pergunta a um assistente virtual e receber uma resposta. É assim que os chatbots e sistemas de processamento de linguagem natural funcionam, permitindo que os usuários se comuniquem de forma mais natural e obtenham respostas relevantes.

## Observações Importantes
Antes de finalizar, preciso deixar uma observação chave (sim, foi um trocadilho ruim, desculpa!): No script do projeto, as referências às chaves de API e ID da organização e Cliente da API da OpenAI foram feitas de forma que você, ao baixar e utilizar esse projeto, possa adicionar suas próprias informações. E mais importante ainda: quem tem acesso às chaves tem acesso à API, então, se você assinar um plano da API, não faz muito sentido colocar as chaves diretamente no script, né? É bem melhor fazer a referência direta no Inspector da Unity. Ah, e claro, os usuários do aplicativo final não terão acesso direto a essas chaves, pois eles acessarão através do front-end da UI que foi criada. Fiquem tranquilos! 😉


</div>

<div align="center">
 
![4](https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/e55bf39b-29a3-4277-a5d4-9ae2d69d6c9e)


</div>

</div>

<div align="center">

 📸 Imagem 02 - Referências de autenticação no Inspector da Unity  📸

</div>

------

Enfim, é isso. Vou continuar trabalhando nesse projeto nas próximas semanas e, quem sabe, fazer uma vaquinha online para ajudar a pagar a API (se alguém estiver disposto, rsrsrs). Fique de olho no projeto e, se você gostou, só entrar em contato com as minhas redes abaixo! Valeu!


<img align='center' src='https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/edb90982-eab9-44df-93b3-4aca95436811.gif' width='180"'> 

-------
