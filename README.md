# ContacMVC

- Essa é uma aplicação ASP.NET Core MVC que aplica operações CRUD em um sistema de cadastro, listagem, edição e remoção de contatos. Foi utilizado o .NET 8 no Visual Studio 2022 e o PostgreSQL como banco de dados para armazenamento dos contatos. Este projeto foi feito como parte dos meus estudos de C# e .NET.

- O PostgreSQL e o seu sistema gerenciador de banco de dados PgAdmin estão em um container Docker que também está neste repositório dentro da pasta "PostgreSQL_PgAdmin".
<br>
<br>

___
##  Como executar o projeto?
Caso você queira executar o projeto siga as instruções:
1. Certifique-se de ter o Docker instalado em sua máquina. Você pode baixá-lo [aqui](https://www.docker.com/get-started).

2. Certifique-se de ter o Visual Studio instalado também. Você pode baixá-lo [aqui](https://visualstudio.microsoft.com/pt-br/downloads/).

3. Clone este repositório em sua máquina local.

4. Navegue até o diretório **"PostgreSQL_PgAdmin"** e execute o comando: docker-compose up no terminal, para iniciar o container Docker do banco de dados.

5. Abra a pasta Contact, da raiz deste repositório, no Visual Studio.

6. Esse projeto utiliza os pacotes:
   - **Microsoft.EntityFrameworkCore**
   - **Microsoft.EntityFrameworkCore.Tools**
   - **Npgsql.EntityFrameworkCore.PostgreSQL**
- Caso os pacotes não sejam carregados, você vai precisar instalá-los utilizando o **Gerenciador de Pacotes do NuGet** no Visual Studio, procurando por eles na ferramenta de pesquisa.

7. Após instalar todos os pacotes acima, entre no Console do Gerenciador de Pacotes e digite os comandos: 
   - **Remove-Migration** para remover qualquer migração que já esteja criada e não ocorrerem conflitos.
   - **Add-Migration** para ser criada a migração do banco de dados com o projeto por meio do Entity Framework Core.
   -  **Update-Database** para atualizar as alterações com o banco de dados.
  
8. Execute o projeto no Visual Studio e teste a aplicação!

## Tecnologias utilizadas:
- ASP.NET Core MVC
- HTML, CSS, Javascript
- JQuery
- PostgreSQL
- Docker

## Observações:
-   As credenciais e *strings* de conexão padrões do banco de dados estão no arquivo _**docker-compose.yml**_ de **"PostgreSQL_PgAdmin"**, você pode alterar elas.
-   Caso queira acessar o SGBD do banco de dados (PgAdmin), acesse o localhost na porta que está definida no _**docker-compose.yml**_. Ex.: localhost:8080.