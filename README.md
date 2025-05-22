# MvcClient

Este projeto é uma aplicação ASP.NET Core MVC que demonstra um sistema de cadastro de **clientes** e **fornecedores**, utilizando o **Entity Framework Core** para acesso a dados e usando .NET 9.0 .

---

## 🧰 Tecnologias Utilizadas

- [.NET 9.0](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- Bootstrap 5

---

## 📦 Estrutura do Projeto

- `Models/` – Classes de domínio como `Person`, `Customer` e `Supplier`
- `Data/` – Contexto de banco de dados (`AppDbContext`)
- `Controllers/` – Controladores MVC
- `Views/` – Páginas Razor (CRUD)
- `Migrations` - Migrações do Entity Framework Core
- `wwwroot/` – Arquivos estáticos (CSS, JS, etc.)

---

## 🚀 Como Executar

### Pré-requisitos

- .NET 9.0 SDK
- SQL Server (local ou remoto) ou Visual Studio (que já vem com o SQL Server Express)

### Passo a passo

1. **Clone o repositório:**

   ```bash
   git clone https://github.com/ezequielsan/MvcClient.git
   cd MvcClient
   ```
2. **Restaure as dependências:**
   ```bash
   dotnet restore
   ```
3. **Configure a string de conexão:**
   - Edite o arquivo `appsettings.json` e ajuste a chave `ConnectionStrings:MvcClientContext` para apontar para sua instância do SQL Server.
   - Exemplo:
   ```json
   "ConnectionStrings": {
       "MvcClientContext": "Server=(localdb)\\mssqllocaldb;Database=MvcClientContext-2744821d-328d-4f55-aadf-c46741363b8f;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
   ```
4. **Aplique as migrações e crie o banco de dados:**
   ```bash
   dotnet ef database update
   ```
5. **Execute a aplicação:**
   ```bash
   dotnet run          
   ```
   Ou pressione `F5` no Visual Studio.

---

## 🗂️ Funcionalidades

- Cadastro, edição, listagem, detalhes e exclusão de **clientes** e **fornecedores**
- Validação de dados no frontend e backend
- Seed automático de dados de exemplo ao iniciar a aplicação (veja `Models/SeedData.cs`)
- Pesquisa por nome de cliente na tela de listagem

---

## 📝 Observações

- O projeto utiliza Razor Pages com controladores e views para cada entidade.
- O seed de dados só é executado se as tabelas estiverem vazias.
- Para atualizar os dados de seed, limpe o banco de dados antes de rodar novamente.

---

## 📄 Licença

Este projeto está sob a licença MIT.