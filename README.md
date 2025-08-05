# SOLID_Principles

## Exerc�cios - Single Responsibility Principle (SRP)

O Princ�pio da Responsabilidade �nica afirma que uma classe deve ter apenas uma raz�o para mudar, ou seja, deve ter uma �nica responsabilidade bem definida.

### Exerc�cio 1: Sistema de Usu�rio
**Problema:** A classe `Usuario` abaixo viola o SRP. Identifique as viola��es e refatore o c�digo separando as responsabilidades.
public class Usuario
{
    public string Nome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    public void SalvarNoBancoDeDados()
    {
        // L�gica para salvar no banco
        Console.WriteLine($"Salvando {Nome} no banco de dados...");
    }

    public void EnviarEmailBoasVindas()
    {
        // L�gica para enviar email
        Console.WriteLine($"Enviando email de boas-vindas para {Email}...");
    }

    public bool ValidarEmail()
    {
        // L�gica de valida��o de email
        return Email.Contains("@") && Email.Contains(".");
    }

    public void GerarRelatorioUsuario()
    {
        // L�gica para gerar relat�rio
        Console.WriteLine($"Relat�rio: {Nome}, {Email}");
    }
}
**Tarefa:** Refatore criando classes separadas para cada responsabilidade.

---

### Exerc�cio 2: Sistema de Pedidos
**Problema:** A classe `Pedido` est� fazendo muitas coisas. Refatore seguindo o SRP.
public class Pedido
{
    public int Id { get; set; }
    public List<string> Itens { get; set; } = new();
    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public decimal CalcularDesconto()
    {
        // L�gica complexa de desconto
        if (Valor > 100) return Valor * 0.1m;
        return 0;
    }

    public void ProcessarPagamento()
    {
        // L�gica de pagamento
        Console.WriteLine($"Processando pagamento de R$ {Valor}");
    }

    public void EnviarNotificacaoCliente()
    {
        // L�gica de notifica��o
        Console.WriteLine("Enviando notifica��o ao cliente...");
    }

    public void SalvarPedido()
    {
        // L�gica de persist�ncia
        Console.WriteLine($"Salvando pedido {Id} no banco...");
    }

    public void GerarNotaFiscal()
    {
        // L�gica de nota fiscal
        Console.WriteLine($"Gerando nota fiscal para pedido {Id}");
    }
}
**Tarefa:** Identifique as diferentes responsabilidades e crie classes separadas.

---

### Exerc�cio 3: Sistema de Funcion�rios
**Problema:** A classe `Funcionario` tem responsabilidades misturadas. Refatore o c�digo.
public class Funcionario
{
    public string Nome { get; set; }
    public decimal Salario { get; set; }
    public string Departamento { get; set; }

    public decimal CalcularSalarioComBonus()
    {
        // L�gica de c�lculo de b�nus
        return Salario * 1.1m;
    }

    public void GerarFolhaPagamento()
    {
        // L�gica de folha de pagamento
        Console.WriteLine($"Folha: {Nome} - R$ {CalcularSalarioComBonus()}");
    }

    public void EnviarEmailAniversario()
    {
        // L�gica de email de anivers�rio
        Console.WriteLine($"Enviando parab�ns para {Nome}!");
    }

    public void SalvarDadosFuncionario()
    {
        // L�gica de persist�ncia
        Console.WriteLine($"Salvando dados de {Nome}...");
    }

    public void GerarCracha()
    {
        // L�gica de gera��o de crach�
        Console.WriteLine($"Gerando crach� para {Nome} - {Departamento}");
    }
}
**Tarefa:** Separe as responsabilidades em classes apropriadas.

---

### Exerc�cio 4: Sistema de Biblioteca
**Problema:** A classe `Livro` est� violando o SRP. Refatore o c�digo.
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
            // L�gica de empr�stimo
            Console.WriteLine($"Livro '{Titulo}' emprestado para {nomeUsuario}");
            
            // Salvar no banco
            Console.WriteLine("Salvando empr�stimo no banco...");
            
            // Enviar email
            Console.WriteLine($"Enviando confirma��o por email...");
        }
    }

    public void DevolverLivro()
    {
        Disponivel = true;
        Console.WriteLine($"Livro '{Titulo}' devolvido");
        
        // Calcular multa se necess�rio
        Console.WriteLine("Calculando poss�vel multa...");
        
        // Atualizar banco
        Console.WriteLine("Atualizando status no banco...");
    }

    public void GerarRelatorioLivro()
    {
        Console.WriteLine($"Relat�rio: {Titulo} - {Autor} - Dispon�vel: {Disponivel}");
    }
}
**Tarefa:** Identifique as viola��es do SRP e crie as classes apropriadas.

---

### Exerc�cio 5: Sistema de Log
**Problema:** A classe `Logger` est� fazendo mais do que deveria. Refatore seguindo o SRP.
public class Logger
{
    public void LogError(string mensagem)
    {
        string logFormatado = $"[ERROR] {DateTime.Now}: {mensagem}";
        
        // Salvar em arquivo
        File.AppendAllText("log.txt", logFormatado + Environment.NewLine);
        
        // Enviar por email se for cr�tico
        if (mensagem.Contains("CRITICAL"))
        {
            Console.WriteLine($"Enviando email de erro cr�tico: {mensagem}");
        }
        
        // Salvar no banco de dados
        Console.WriteLine("Salvando log no banco de dados...");
        
        // Mostrar no console
        Console.WriteLine(logFormatado);
        
        // Comprimir logs antigos se necess�rio
        if (File.Exists("log.txt") && new FileInfo("log.txt").Length > 1000000)
        {
            Console.WriteLine("Comprimindo logs antigos...");
        }
    }
}
**Tarefa:** Refatore criando classes com responsabilidades �nicas para cada tipo de opera��o de log.

---

## Dicas para Implementa��o:
1. Identifique quantas responsabilidades cada classe tem
2. Pense em nomes descritivos para as novas classes
3. Mantenha as interfaces simples e focadas
4. Teste cada classe separadamente
5. Use inje��o de depend�ncia quando necess�rio

## Como Implementar:
1. Crie as classes refatoradas no arquivo `Program.cs`
2. Implemente um exemplo de uso no m�todo `Main`
3. Teste para garantir que o comportamento original foi mantido
4. Solicite avalia��o quando terminar

**Boa sorte com os exerc�cios!** ??