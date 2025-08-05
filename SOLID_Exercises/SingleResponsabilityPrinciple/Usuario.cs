namespace SOLID_Principles.SOLID_Exercises.SingleResponsabilityPrinciple
{
    public class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }

        public Usuario(string nome, string email, string senha)
        {
            Nome = nome;
            Email = email;
            Senha = senha;
        }
    }

    public class ReportGenerator
    {
        public void GerarRelatorioUsuario(Usuario user)
        {
            // Lógica para gerar relatório
            Console.WriteLine($"Relatório: {user.Nome}, {user.Email}");
        }
    }

    public class SaveService
    {
        public void SalvarNoBancoDeDados(Usuario user)
        {
            // Lógica para salvar no banco
            Console.WriteLine($"Salvando {user.Nome} no banco de dados...");
        }
    }

    public class EmailSenderService
    {
        public void EnviarEmailBoasVindas(Usuario user)
        {
            // Lógica para enviar email
            Console.WriteLine($"Enviando email de boas-vindas para {user.Email}...");
        }
    }

    public class EmailValidatorService
    {
        public bool ValidarEmail(Usuario user)
        {
            // Lógica de validação de email
            return user.Email.Contains("@") && user.Email.Contains(".");
        }
    }
}
