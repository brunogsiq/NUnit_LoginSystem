using System.Collections.Generic;
using System.Linq;
using LoginSystem.Models;

namespace LoginSystem.Services
{
    public class AuthService
    {
        private readonly List<User> _users;

        public AuthService()
        {
            // Simulação de banco de dados (usuários cadastrados)
            _users = new List<User>
            {
                new User("admin", "1234"),
                new User("user", "senha"),
                new User("bruno", "1910")
            };
        }

        // Alterando o método Login para permitir strings nulas
        public bool Login(string? username, string? password)
        {
            // Verifica se o username ou password estão vazios ou nulos
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                return false; // Retorna falso se houver valores nulos ou vazios
            }

            // Lógica de autenticação usando a lista de usuários simulados
            return _users.Any(user => user.Username == username && user.Password == password);
        }
    }
}
