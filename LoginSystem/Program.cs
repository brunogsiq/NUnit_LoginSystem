using System;
using LoginSystem.Services;

class Program
{
    static void Main()
    {
        var authService = new AuthService();

        Console.Write("Usuário: ");
        string username = Console.ReadLine() ?? string.Empty; // Garante que nunca seja null

        Console.Write("Senha: ");
        string password = Console.ReadLine() ?? string.Empty; // Garante que nunca seja null


        // Chama o método Login e armazena o resultado booleano
        bool loginSuccess = authService.Login(username, password);

        // Exibe a mensagem dependendo do sucesso ou falha do login
        if (loginSuccess)
        {
            Console.WriteLine("Login bem-sucedido!");
        }
        else
        {
            Console.WriteLine("Usuário ou senha incorretos.");
        }
    }
}
