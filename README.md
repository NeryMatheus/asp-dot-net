# Aplicação Web ASP.NET Core MVC

## Extensões Recomendadas para Visual Studio Code:
1. **.NET Core Test Explorer**
2. **C#**
3. **C# Extensions**
4. **Live Server**
5. **Markdown Preview Enhanced**

## Pré-requisitos:
- [.NET Core SDK 6.0 ou superior](https://dotnet.microsoft.com/en-us/download)

### ORM Utilizada:

1. Entity Framework Core: [Link para o pacote NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore.SqlServer)
2. Entity Framework Core SQL Server: [Link para o pacote NuGet](https://www.nuget.org/packages/Microsoft.EntityFrameworkCore)

### Sobre a ORM:

 - O Entity Framework Core foi escolhido como a ORM (Object-Relational Mapping) para facilitar o acesso e manipulação de dados no aplicativo. O suporte ao SQL Server foi adicionado para integrar o banco de dados ao projeto.
 - Certifique-se de ter o SDK do .NET Core instalado antes de iniciar o desenvolvimento.

### ✔️ Estrutura do Projeto:

 - O projeto segue uma modelagem arquitetural organizada em camadas (Web, Service, Infra e Domain). Certifique-se de instalar as dependências corretamente em cada camada para garantir um fluxo de dados consistente.
- Para mais informações sobre o ASP.NET Core MVC, [consulte a documentação oficial](https://jakeydocs.readthedocs.io/en/latest/)