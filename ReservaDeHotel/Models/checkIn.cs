using ReservaHotel.Models;
namespace checkIn.Models;
public class Checkin
{
    public int Id { get; set; }
    public int ReservaId { get; set; }
    public DateTime DataCheckin { get; set; }
    public bool Concluido { get; set; }

    // Relacionamento com a reserva
    public Reserva? Reserva { get; set; }
}