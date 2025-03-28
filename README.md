# NUnit_LoginSystem - Sistema de Login - Projeto de Autenticação

Este é um projeto simples de sistema de login em C#, utilizando o framework NUnit para testes automatizados. O sistema permite que os usuários se autentiquem com um nome de usuário e senha. Ele inclui testes para garantir que a autenticação funcione corretamente.

## Funcionalidade

O sistema permite o login de usuários com credenciais válidas ou inválidas, com as seguintes funcionalidades:

- Login com nome de usuário e senha.
- Mensagens de sucesso ou erro de autenticação.
- Validação de campos de entrada vazios ou nulos.

## Tecnologias Utilizadas

- **.NET 8.0** - Framework para construção de aplicações.
- **NUnit** - Framework de testes unitários.
- **C#** - Linguagem de programação principal.
- **Console Application** - Aplicação de console simples para interação com o usuário.

## Estrutura do Projeto

O projeto está dividido nas seguintes seções:

- **LoginSystem**: Contém a lógica de autenticação do sistema.
- **LoginSystem.Tests**: Contém os testes unitários para garantir que a autenticação e a validação de credenciais estejam funcionando corretamente.

## Como Executar o Projeto

### Requisitos

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download) instalado em sua máquina.

### Passos para Execução

1. Clone o repositório:
   ```bash
   git clone https://github.com/seu-usuario/repositorio.git
   ```

2. Navegue até a pasta do projeto:
   ```bash
   cd LoginSystem
   ```

3. Compile e execute o projeto:
   ```bash
   dotnet run
   ```

4. O sistema pedirá para inserir o nome de usuário e a senha no terminal. O login será validado com base nas credenciais cadastradas no código.

### Como Executar os Testes

1. Navegue até a pasta de testes:
   ```bash
   cd LoginSystem.Tests
   ```

2. Execute os testes utilizando o comando:
   ```bash
   dotnet test
   ```

Os testes verificarão as funcionalidades de autenticação, incluindo login com credenciais válidas, credenciais inválidas, campos nulos e vazios.

## Estrutura de Diretórios

```
LoginSystem
│   Program.cs               # Arquivo principal de execução
│   AuthService.cs           # Lógica de autenticação
│
└───LoginSystem.Tests
    │   AuthServiceTests.cs  # Testes unitários para autenticação
```

## Contribuindo

Sinta-se à vontade para fazer melhorias ou correções! Se você deseja contribuir, siga as etapas abaixo:

1. Fork o repositório.
2. Crie uma branch para suas alterações (`git checkout -b minha-nova-feature`).
3. Faça as alterações e envie um pull request.

## Licença

Este projeto está sob a [MIT License](LICENSE).

```