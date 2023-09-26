using ReservaHotel.Models;
namespace pagamento.Models;
public class Pagamento
{
    public int Id { get; set; }
    public int ReservaId { get; set; }
    public decimal Valor { get; set; }
    public DateTime DataPagamento { get; set; }
    public string? Metodo { get; set; }
    public bool Confirmado { get; set; }

    // Relacionamento com a reserva
    public Reserva? Reserva { get; set; }
}