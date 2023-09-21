# Projeto de CRUD com C# e Visual Studio 2022

Este é um exemplo de projeto de um aplicativo CRUD (Create, Read, Update, Delete) desenvolvido em C# utilizando o ASP.NET Core e o Visual Studio 2022. O projeto permite o gerenciamento de produtos em um sistema de controle de estoque. O objetivo é conectar a um banco de dados do SQL Server para construir o CRUD com o MVC do Visual Studio.

## Pacotes Instalados

Para este projeto, foram instalados os seguintes pacotes NuGet:

- Microsoft.EntityFrameworkCore
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.SqlServer

Certifique-se de que esses pacotes estejam instalados em seu ambiente antes de executar o projeto.

## Configuração do Banco de Dados

O projeto utiliza o Entity Framework Core para a interação com o banco de dados. A configuração do banco de dados está presente no arquivo `Program.cs`. Verifique se o caminho do banco de dados em `AttachDbFilename` é válido para o seu ambiente.

```csharp
services.AddDbContext<Contexto>(options => options.UseSqlServer(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\User\OneDrive\Documentos\seudbaqui.mdf;Integrated Security=True;Connect Timeout=30"));
```

## Comandos de Migração

Para criar e aplicar as migrações ao banco de dados, os seguintes comandos foram utilizados:

1. `Add-Migration Criacao-Inicial -Context Contexto`
2. `Update-database -Context Contexto`

Certifique-se de executar esses comandos no console do Visual Studio ou no terminal do seu ambiente para criar a estrutura do banco de dados.

## Executando o Projeto

Após configurar o banco de dados e aplicar as migrações, você pode executar o projeto. Certifique-se de definir o projeto da web como projeto de inicialização.

## Funcionalidades

O projeto inclui as seguintes funcionalidades:

- Listagem de produtos com opção de visualização detalhada, edição e exclusão.
- Adição de novos produtos.
- Edição de produtos existentes.
- Exclusão de produtos.
- Interface de usuário amigável.

## Contribuições

Contribuições são bem-vindas! Se você quiser melhorar este projeto, sinta-se à vontade para criar um fork e enviar um pull request.

