using NUnit.Framework;
using LoginSystem.Services;
using LoginSystem.Models;

namespace LoginSystem.Tests
{
    [TestFixture]
    public class AuthServiceTests
    {
        private AuthService _authService;

        [SetUp] // Executado antes de cada teste
        public void Setup()
        {
            _authService = new AuthService();
        }

        [Test]
        public void teste01_Login_ComCredenciaisValidas_DeveRetornarMensagemDeSucesso()
        {
            // Arrange
            string username = "admin";
            string password = "1234";
            string expectedMessage = "Login bem-sucedido!";

            // Act
            bool loginSuccess = _authService.Login(username, password);
            string actualMessage = loginSuccess ? "Login bem-sucedido!" : "Usuário ou senha incorretos.";

            // Assert
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void teste02_Login_ComUsuarioInvalido_DeveRetornarMensagemDeErro()
        {
            // Arrange
            string username = "invalidUser";
            string password = "1234";
            string expectedMessage = "Usuário ou senha incorretos.";

            // Act
            bool loginSuccess = _authService.Login(username, password);
            string actualMessage = loginSuccess ? "Login bem-sucedido!" : "Usuário ou senha incorretos.";

            // Assert
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void teste03_Login_ComSenhaInvalida_DeveRetornarMensagemDeErro()
        {
            // Arrange
            string username = "admin";
            string password = "wrongPassword";
            string expectedMessage = "Usuário ou senha incorretos.";

            // Act
            bool loginSuccess = _authService.Login(username, password);
            string actualMessage = loginSuccess ? "Login bem-sucedido!" : "Usuário ou senha incorretos.";

            // Assert
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void teste04_Login_ComCamposVazios_DeveRetornarMensagemDeErro()
        {
            // Arrange
            string username = "";
            string password = "";
            string expectedMessage = "Usuário ou senha incorretos.";

            // Act
            bool loginSuccess = _authService.Login(username, password);
            string actualMessage = loginSuccess ? "Login bem-sucedido!" : "Usuário ou senha incorretos.";

            // Assert
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void teste05_Login_ComCamposNulos_DeveRetornarMensagemDeErro()
        {
            // Arrange
            string username = string.Empty;
            string password = string.Empty;
            string expectedMessage = "Usuário ou senha incorretos.";

            // Act
            bool loginSuccess = _authService.Login(username, password);
            string actualMessage = loginSuccess ? "Login bem-sucedido!" : "Usuário ou senha incorretos.";

            // Assert
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }

        [Test]
        public void teste06_Login_ComCamposNulos_DeveRetornarMensagemDeErro()
        {
            // Arrange
            string username = null;
            string password = null;
            string expectedMessage = "Usuário ou senha incorretos.";

            // Act
            bool loginSuccess = _authService.Login(username, password);
            string actualMessage = loginSuccess ? "Login bem-sucedido!" : "Usuário ou senha incorretos.";

            // Assert
            Assert.That(actualMessage, Is.EqualTo(expectedMessage));
        }
    }
}