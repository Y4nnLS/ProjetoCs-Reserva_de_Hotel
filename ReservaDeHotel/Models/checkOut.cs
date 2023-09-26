using ReservaHotel.Models;
namespace checkOut.Models;

public class Checkout
{
    public int Id { get; set; }
    public int ReservaId { get; set; }
    public DateTime DataCheckout { get; set; }
    public decimal ValorTotal { get; set; }
    public bool Concluido { get; set; }

    // Relacionamento com a reserva
    public Reserva? Reserva { get; set; }
}