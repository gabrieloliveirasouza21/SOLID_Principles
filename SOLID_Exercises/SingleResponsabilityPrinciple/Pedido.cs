using System.Drawing;

namespace SOLID_Principles.SOLID_Exercises.SingleResponsabilityPrinciple
{
    public class Pedido
    {
        public int Id { get; set; }
        public List<string> Itens { get; set; } = new();
        public decimal Valor { get; set; }
        public DateTime Data { get; set; }

        public Pedido(int id, List<string> itens, decimal valor, DateTime data)
        {
            Id = id;
            Itens = itens;
            Valor = valor;
            Data = data;
        }
    }

    public class DiscountCalculator
    {
        public decimal CalcularDesconto(Pedido pedido)
        {
            // Lógica complexa de desconto
            if (pedido.Valor > 100) return pedido.Valor * 0.1m;
            return 0;
        }
    }

    public class PaymentProcessor
    {
        public void ProcessarPagamento(Pedido pedido)
        {
            // Lógica de pagamento
            Console.WriteLine($"Processando pagamento de R$ {pedido.Valor}");
        }
    }

    public class NotificationSender
    {
        public void EnviarNotificacaoCliente(Pedido pedido)
        {
            // Lógica de notificação
            Console.WriteLine($"Enviando notificação do pedido {pedido.Id} ao cliente...");
        }
    }

    public class OrderSaveService
    {
        public void SalvarPedido(Pedido pedido)
        {
            // Lógica de persistência
            Console.WriteLine($"Salvando pedido {pedido.Id} no banco...");
        }
    }

    public class GeradorNotaFiscal
    {
        public void GerarNotaFiscal(Pedido pedido)
        {
            // Lógica de nota fiscal
            Console.WriteLine($"Gerando nota fiscal para pedido {pedido.Id}");
        }
    }
}
