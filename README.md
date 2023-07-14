# ChatGPT em Unity
![2](https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/597b2d9b-75cb-4528-aeff-b57a1fd7fd55)

Bem-vindo(a) ao ChatGPT em Unity, um projeto incrível que une a poderosa tecnologia do ChatGPT da OpenAI com uma interface de bate-papo divertida e envolvente, especialmente desenvolvida para adolescentes e crianças. 🤖💬

## Sobre o Projeto
Após um mês de dedicação nesse projeto, enfrentando alguns obstáculos ao longo do caminho (a API da OpenAI bloqueando meu acesso sem motivo, sério?!), decidi não desistir e resolvi trocar de conta na OpenAI. E adivinha? O limite free para uso da API estava relacionado ao tempo de uso, não ao acesso em si. Ou seja, meu limite tinha estourado na conta antiga. Enfim, consegui utilizar uma nova chave disponível e um ID da organização gratuito também. 💪

Mas chega de drama, vamos falar sobre o app. A minha ideia era criar algo para dispositivos móveis, direcionado para o público jovem, onde eles pudessem reviver aquela sensação nostálgica de conversar com o mago Merlin no antigo prompt do Windows 98 (lembram disso? rsrs). E assim, nasceu esse projeto.

![mobileimgtela](https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/8068b0a6-d3b8-4aa3-9de7-df5f4ce094d7)

## Principais Recursos
Basicamente, o que eu quis fazer foi chamar a API da OpenAI, integrar o ChatGPT no projeto (a parte que me deu duas semanas de tristeza) e configurar uma interface de bate-papo legal. Até agora, consegui implementar grupos de layout horizontal e vertical, visualização de rolagem, botão integrado com toda a lógica, elementos de layout personalizáveis e até mesmo um ajustador de tamanho de conteúdo. Tem um monte de outras coisas também, mas essas são as principais. 😄🚀

Na próxima versão, estou planejando adicionar recursos de Text-To-Speech e Speech-To-Text ao projeto, utilizando o Oculus SDK. Além disso, quero implementar um recurso para salvar o histórico de todas as conversas que o usuário teve com o ChatGPT. Vai ficar ainda mais legal! 👍

Ah, e não menos importante, vamos falar sobre monetização. Como a API da OpenAI não é gratuita para fins comerciais (queria que fosse, mas né...), estou pensando em usar o Activity Manager para rastrear a atividade do usuário. Depois de um certo número de interações no chat, eles terão que assistir a um vídeo ou assinar o serviço para remover os anúncios. Eu queria deixar tudo de graça, mas a vida é assim, precisamos nos sustentar. Para facilitar a monetização, vou integrar o novo sistema de Mediação de Anúncios da Unity. 💰💡

## Boas Práticas e Desafios
No script do projeto, estou seguindo boas práticas de programação (você vai concordar comigo, né?! rsrs). Uso coisas legais como actions, unity events, headers e tudo mais. Eu sei, poderia comentar mais o código, mas fiz o meu melhor, juro! 😉💻

A maior dificuldade que enfrentei foi elaborar o Callback para o botão de envio de mensagem. Sinceramente, sem a ajuda do ChatGPT, eu não sairia do lugar nesse ponto. Nessa parte do código, o programa está se comunicando com o ChatGPT, que é um modelo de linguagem super inteligente capaz de gerar respostas com base em um contexto fornecido. A função GetCompletionAsync é responsável por enviar uma solicitação para o ChatGPT, contendo as mensagens anteriores da conversa e outros parâmetros relevantes, como o modelo a ser utilizado e a temperatura de geração das respostas. Quanto às respostas um tanto "humorísticas", ainda não descobri o motivo, mas talvez o algoritmo esteja aprendendo e se adaptando ao estilo de cada usuário. Vamos ver como ele se comporta! 😄💬

Depois de enviar a solicitação, o programa fica aguardando a resposta do ChatGPT, que é recebida assincronamente (isso significa que, ao marcar a função como async e usar o await, o programa continua executando outras tarefas enquanto espera pela resposta da API. Nada de ficar travado!). Em seguida, tratamos a resposta e a exibimos ao usuário, geralmente em uma bolha de discussão. Essa interação de enviar uma mensagem, obter uma resposta e mostrá-la ao usuário é bem parecida com o processo de fazer uma pergunta a um assistente virtual e receber uma resposta. É assim que os chatbots e sistemas de processamento de linguagem natural funcionam, permitindo que os usuários se comuniquem de forma mais natural e obtenham respostas relevantes.

## Observações Importantes
Antes de finalizar, preciso deixar uma observação chave (sim, foi um trocadilho ruim, desculpa!): No script do projeto, as referências às chaves de API, ID da organização e Cliente da API da OpenAI foram feitas de forma que você, ao baixar e utilizar esse projeto, possa adicionar suas próprias informações. E mais importante ainda: quem tem acesso às chaves tem acesso à API, então, se você assinar um plano da API, não faz muito sentido colocar as chaves diretamente no script, né? É bem melhor fazer a referência direta no Inspector da Unity. Ah, e claro, os usuários do aplicativo final não terão acesso direto a essas chaves, pois eles acessarão através do front-end da UI que foi criada. Fiquem tranquilos! 😉

Enfim, é isso. Vou continuar trabalhando nesse projeto nas próximas semanas e, quem sabe, fazer uma vaquinha online para ajudar a pagar a API (se alguém estiver disposto, rsrsrs). Fique de olho no projeto se você gostou! Valeu, galera! 🙌🔥
