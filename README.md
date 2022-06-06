# aspnet-redis-provider-session-state

Projeto criado para exemplificar a utilização do Redis (banco de dados NOSQL) como provedor de estado de sessão para o asp.net.

O objetivo é criar um modelo de cache distribuído para armazenar os dados de sessão.

Neste exemplo a aplicação Asp.NET em MVC utiliza o Redis para armazenar os valores de duas variáveis de sessão: id e nome do usuário

## O passo a passo para rodar o projeto

Você precisa subir uma instância do Redis e configurar a aplicação para utiliza-lo, para isso, após subir o Redis basta informar seu IP no web.config no seção de sessionSateMode, veja iagem abaixo:

![image](https://user-images.githubusercontent.com/731481/172261274-c1b5d4e7-0fc0-4b3c-8c29-9721118bc99c.png)

Na sequencia execute a aplicação na sua IDE ex Visual Studio ou VsCode


## O passo a passo do zero
 
Crie sua aplicação asp.net MVC e adicione o pacote nuget chamado Microsoft.Web.RedisSessionStateProvider ao seu projeto.

Após adicinar o pacote o arquivo Web.config será modificado recebendo uma nova seção chamada sessionState, é nessa rotina que você informa o IP do Redis

![image](https://user-images.githubusercontent.com/731481/172261274-c1b5d4e7-0fc0-4b3c-8c29-9721118bc99c.png)

Agora é divertir e testar jovens!

