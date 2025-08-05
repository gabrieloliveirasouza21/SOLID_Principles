# SOLID_Principles

## Exercícios - Single Responsibility Principle (SRP)

O Princípio da Responsabilidade Única afirma que uma classe deve ter apenas uma razão para mudar, ou seja, deve ter uma única responsabilidade bem definida.

### Exercício 1: Sistema de Usuário
**Problema:** A classe `Usuario` abaixo viola o SRP. Identifique as violações e refatore o código separando as responsabilidades.
public class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public void SalvarNoBancoDeDados()
    {
        // Lógica para salvar no banco
        Console.WriteLine($"Salvando {Nome} no banco de dados...");
    }

    public void EnviarEmailBoasVindas()
    {
        // Lógica para enviar email
        Console.WriteLine($"Enviando email de boas-vindas para {Email}...");
    }

    public bool ValidarEmail()
    {
        // Lógica de validação de email
        return Email.Contains("@") && Email.Contains(".");
    }

    public void GerarRelatorioUsuario()
    {
        // Lógica para gerar relatório
        Console.WriteLine($"Relatório: {Nome}, {Email}");
    }
}
**Tarefa:** Refatore criando classes separadas para cada responsabilidade.

---

### Exercício 2: Sistema de Pedidos
**Problema:** A classe `Pedido` está fazendo muitas coisas. Refatore seguindo o SRP.
public class Pedido
{
    public int Id { get; set; }
    public List<string> Itens { get; set; } = new();
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public decimal CalcularDesconto()
    {
        // Lógica complexa de desconto
        if (Valor > 100) return Valor * 0.1m;
        return 0;
    }

    public void ProcessarPagamento()
    {
        // Lógica de pagamento
        Console.WriteLine($"Processando pagamento de R$ {Valor}");
    }

    public void EnviarNotificacaoCliente()
    {
        // Lógica de notificação
        Console.WriteLine("Enviando notificação ao cliente...");
    }

    public void SalvarPedido()
    {
        // Lógica de persistência
        Console.WriteLine($"Salvando pedido {Id} no banco...");
    }

    public void GerarNotaFiscal()
    {
        // Lógica de nota fiscal
        Console.WriteLine($"Gerando nota fiscal para pedido {Id}");
    }
}
**Tarefa:** Identifique as diferentes responsabilidades e crie classes separadas.

---

### Exercício 3: Sistema de Funcionários
**Problema:** A classe `Funcionario` tem responsabilidades misturadas. Refatore o código.
public class Funcionario
{
    public string Nome { get; set; }
    public decimal Salario { get; set; }
    public string Departamento { get; set; }

    public decimal CalcularSalarioComBonus()
    {
        // Lógica de cálculo de bônus
        return Salario * 1.1m;
    }

    public void GerarFolhaPagamento()
    {
        // Lógica de folha de pagamento
        Console.WriteLine($"Folha: {Nome} - R$ {CalcularSalarioComBonus()}");
    }

    public void EnviarEmailAniversario()
    {
        // Lógica de email de aniversário
        Console.WriteLine($"Enviando parabéns para {Nome}!");
    }

    public void SalvarDadosFuncionario()
    {
        // Lógica de persistência
        Console.WriteLine($"Salvando dados de {Nome}...");
    }

    public void GerarCracha()
    {
        // Lógica de geração de crachá
        Console.WriteLine($"Gerando crachá para {Nome} - {Departamento}");
    }
}
**Tarefa:** Separe as responsabilidades em classes apropriadas.

---

### Exercício 4: Sistema de Biblioteca
**Problema:** A classe `Livro` está violando o SRP. Refatore o código.
public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }
    public string ISBN { get; set; }
    public bool Disponivel { get; set; } = true;

    public void EmprestarLivro(string nomeUsuario)
    {
        if (Disponivel)
        {
            Disponivel = false;
            // Lógica de empréstimo
            Console.WriteLine($"Livro '{Titulo}' emprestado para {nomeUsuario}");
            
            // Salvar no banco
            Console.WriteLine("Salvando empréstimo no banco...");
            
            // Enviar email
            Console.WriteLine($"Enviando confirmação por email...");
        }
    }

    public void DevolverLivro()
    {
        Disponivel = true;
        Console.WriteLine($"Livro '{Titulo}' devolvido");
        
        // Calcular multa se necessário
        Console.WriteLine("Calculando possível multa...");
        
        // Atualizar banco
        Console.WriteLine("Atualizando status no banco...");
    }

    public void GerarRelatorioLivro()
    {
        Console.WriteLine($"Relatório: {Titulo} - {Autor} - Disponível: {Disponivel}");
    }
}
**Tarefa:** Identifique as violações do SRP e crie as classes apropriadas.

---

### Exercício 5: Sistema de Log
**Problema:** A classe `Logger` está fazendo mais do que deveria. Refatore seguindo o SRP.
public class Logger
{
    public void LogError(string mensagem)
    {
        string logFormatado = $"[ERROR] {DateTime.Now}: {mensagem}";
        
        // Salvar em arquivo
        File.AppendAllText("log.txt", logFormatado + Environment.NewLine);
        
        // Enviar por email se for crítico
        if (mensagem.Contains("CRITICAL"))
        {
            Console.WriteLine($"Enviando email de erro crítico: {mensagem}");
        }
        
        // Salvar no banco de dados
        Console.WriteLine("Salvando log no banco de dados...");
        
        // Mostrar no console
        Console.WriteLine(logFormatado);
        
        // Comprimir logs antigos se necessário
        if (File.Exists("log.txt") && new FileInfo("log.txt").Length > 1000000)
        {
            Console.WriteLine("Comprimindo logs antigos...");
        }
    }
}
**Tarefa:** Refatore criando classes com responsabilidades únicas para cada tipo de operação de log.

---

## Dicas para Implementação:
1. Identifique quantas responsabilidades cada classe tem
2. Pense em nomes descritivos para as novas classes
3. Mantenha as interfaces simples e focadas
4. Teste cada classe separadamente
5. Use injeção de dependência quando necessário

## Como Implementar:
1. Crie as classes refatoradas no arquivo `Program.cs`
2. Implemente um exemplo de uso no método `Main`
3. Teste para garantir que o comportamento original foi mantido
4. Solicite avaliação quando terminar

**Boa sorte com os exercícios!** ??