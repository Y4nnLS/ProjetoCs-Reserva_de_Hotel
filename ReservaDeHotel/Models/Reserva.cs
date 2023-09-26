namespace ReservaHotel.Models;
using System.ComponentModel.DataAnnotations;

public class Reserva
{
    [Key]
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
}