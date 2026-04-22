<img align='left' src='https://github.com/CeLo93/CeLo93/assets/92175791/71e3914e-e9be-46ab-be9f-fe7df7312ef4.gif' width="170"> 

# *In Unity*

Bem-vindo(a) ao ChatGPT em Unity, um projeto inovador que combina a potente API do ChatGPT da OpenAI com uma envolvente interface de bate-papo desenvolvida em Unity. Esta aplicação visa entender os padrões e comportamentos das crianças, oferecendo análises comportamentais valiosas. 🤖💬

 
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
Este projeto nasceu como parte do meu TCC da pós-graduação em IA e Machine Learning na PUC Minas. Com dedicação e determinação, enfrentei desafios técnicos, como a integração da API OpenAI e obstáculos de acesso. Minha visão é criar um "psicólogo intermediário" para adolescentes, usando a API da OpenAI de forma envolvente. As conversas são registradas em JSON e armazenadas no AWS S3. Um modelo de Machine Learning está sendo desenvolvido para entender o conteúdo das conversas, detectar sentimentos e fornecer insights aos profissionais de saúde.
 💪


Mas chega de drama, vamos falar sobre o app. A minha ideia é criar um ambiente que possa ser utilizado para uma espécie de "psicólogo" intermediário dos adolescentes. O que quero dizer é que a ideia aqui é utilizar a poderasa API da OpenAI (configurada para ser mais divertida possível) para interagir com as crianças. Todo o log de conversa é gravado em JSON e enviado para um armazenamento AWS S3. Estou desenvolvendo um modelo de Machine Learning para poder entender o conteúdo das conversas, detectar sentimentos e trazer sintomas para os profissionais da saúde. A ideia não é substituir o profissional, e sim ser o máximo assertivo no diagnóstico.

É importante que haja um incentivo dos pais para o uso recorrente do software, pois todo o histórico é gravado e analisado progressivamente durante a vida da criança. Isso pode auxiliar em padrões não detectados nos individuos durante os anos.


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

## Análise Comportamental Avançada

Um componente crucial é o desenvolvimento de um modelo de Machine Learning dedicado a entender o conteúdo das conversas. Isso permite a detecção de sentimentos e padrões ao longo do tempo. Esses insights podem ser extremamente valiosos para profissionais de saúde, ajudando-os a identificar possíveis sintomas e oferecer intervenções adequadas.

## Complementando o Diagnóstico Profissional

Vale destacar que a aplicação não tem a pretensão de substituir profissionais de saúde. Pelo contrário, visa ser um instrumento assertivo para auxiliar no diagnóstico, complementando o trabalho dos especialistas. A análise de dados coletados ao longo do tempo pode proporcionar uma visão mais completa do progresso e comportamento da criança.

## Importância da Participação dos Pais

A participação e incentivo dos pais são essenciais para o sucesso da aplicação. O histórico de conversas é gravado e analisado progressivamente ao longo da vida da criança. Isso pode ser um recurso valioso para identificar padrões que podem não ser imediatamente perceptíveis, auxiliando no desenvolvimento saudável.


## Próximos Passos

Além das funcionalidades atuais, estamos planejando adicionar recursos avançados, como Text-To-Speech e Speech-To-Text através do Oculus SDK. Também estamos trabalhando na implementação de um recurso de histórico completo das conversas com o ChatGPT, proporcionando uma experiência mais enriquecedora.




https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/31891eb8-7400-4cb6-a3fd-38d371d44223


<div align="center">

 🎬 Video 02 - Scroll da tela e conversa 🎬

</div>

## Boas Práticas e Desafios
No desenvolvimento deste projeto, tenho buscado adotar boas práticas de programação para garantir a qualidade e a eficiência do código. Embora todos nós enfrentemos desafios, estou trabalhando para superá-los e entregar um produto sólido. Estou usando recursos como actions, unity events e headers para manter o código organizado e legível. Embora eu saiba que poderia ter incluído mais comentários, fiz o meu melhor para tornar o código compreensível. Espero que minha dedicação se reflita positivamente na experiência do usuário! 😉💻


## Elaborando o Callback para o Botão de Envio de Mensagem
Um dos maiores desafios que encontrei foi criar o Callback para o botão de envio de mensagem. Nesse ponto, a colaboração do ChatGPT foi crucial para me orientar. Essa parte do código envolve a comunicação com o ChatGPT, um modelo de linguagem capaz de gerar respostas contextuais. A função GetCompletionAsync desempenha um papel fundamental, enviando uma solicitação ao ChatGPT com mensagens anteriores da conversa e parâmetros relevantes, como o modelo a ser usado e a temperatura de geração das respostas. Quanto às respostas um tanto "humorísticas", ainda estou investigando essa peculiaridade. Pode ser que o algoritmo esteja aprendendo e se adaptando ao estilo de cada usuário. Planejo conduzir mais testes em diferentes chaves ou contas para entender melhor esse comportamento divertido e único! 😄💬

## Processo de Comunicação Assíncrona
Uma característica importante é a comunicação assíncrona com a API do ChatGPT. Ao marcar a função como async e usar o await, o programa pode continuar executando outras tarefas enquanto aguarda a resposta da API. Isso garante uma experiência fluida para o usuário, sem travamentos. Uma vez recebida a resposta do ChatGPT, o programa a trata e a exibe ao usuário, geralmente em uma bolha de discussão. Essa interação, que envolve enviar uma mensagem, receber uma resposta e apresentá-la ao usuário, é semelhante ao processo de conversar com um assistente virtual. É assim que os chatbots e sistemas de processamento de linguagem natural funcionam, permitindo uma comunicação mais natural e a obtenção de respostas relevantes.


## Considerações Finais
Antes de concluir, quero fazer uma observação importante (mesmo que seja um trocadilho ruim, peço desculpas!): No script do projeto, as referências às chaves de API, ID da organização e Cliente da API da OpenAI foram configuradas para que, ao baixar e utilizar este projeto, você possa facilmente adicionar suas próprias informações. É crucial lembrar que quem tem acesso a essas chaves tem acesso à API. Portanto, se você adquirir um plano da API, é mais seguro não inserir as chaves diretamente no script. É preferível fazer a referência direta no Inspector da Unity. Além disso, os usuários do aplicativo final não terão acesso direto a essas chaves, pois interagirão por meio da interface de usuário que foi desenvolvida. Isso garante a segurança dos dados e a integridade do projeto. Fiquem tranquilos! 😉


</div>

<div align="center">
 
![4](https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/e55bf39b-29a3-4277-a5d4-9ae2d69d6c9e)


</div>

</div>

<div align="center">

 📸 Imagem 02 - Referências de autenticação no Inspector da Unity  📸

</div>

------
Link Artigo no Drive: https://drive.google.com/file/d/15J1zMDFOeI08P6PUZcItjr8akWdcBCrW/view?usp=sharing


Enfim, é isso. Vou continuar trabalhando nesse projeto nas próximas semanas e, quem sabe, fazer uma vaquinha online para ajudar a pagar a API (se alguém estiver disposto, rsrsrs). Fique de olho no projeto e, se você gostou, só entrar em contato com as minhas redes abaixo! Valeu!


<img align='center' src='https://github.com/CeLo93/ChatGPT_em_Unity/assets/92175791/edb90982-eab9-44df-93b3-4aca95436811.gif' width='180"'> 

-------
