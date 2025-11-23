# 🚗 ElevaMotors – Sistema de Gestão de Veículos

Sistema Web desenvolvido para gerenciamento completo de veículos para revenda, incluindo controle de entrada, estoque, valores, status, clientes e integração futura com leads.  
O projeto está sendo desenvolvido com foco em **uso real na empresa Eleva Motors** e também como **portfólio profissional** para oportunidades nacionais e internacionais.

## 🛠️ Tecnologias Utilizadas

- ASP.NET Core 8 (MVC)
- Entity Framework Core 8
- SQL Server LocalDB
- Bootstrap 5
- C# 12
- Visual Studio 2022
- Git & GitHub

## 📦 Estrutura do Projeto

ElevaMotors  
├── Controllers  
├── Models  
├── Views  
├── Data  
│   └── ApplicationDbContext.cs  
├── Migrations  
├── wwwroot  
└── appsettings.json  

## ✨ Funcionalidades

### ✔ Implementado
- Modelo Vehicle
- EF Core configurado
- Banco criado via migrations

### 🚧 Em desenvolvimento
- CRUD de veículos
- Dashboard
- Leads
- Relatórios

## 🖥️ Como Rodar

```bash
git clone https://github.com/AyrtonTAV/ElevaMotors
cd ElevaMotors
dotnet restore
dotnet ef database update
dotnet run
```

## 📄 Licença

MIT License

## 👨‍💻 Desenvolvedor

Ayrton Tavares  
GitHub: https://github.com/AyrtonTAV
