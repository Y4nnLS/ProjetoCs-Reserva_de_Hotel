using System.ComponentModel.DataAnnotations;
namespace ReservaHotel.Models;

public class Hotel
{
    [Key]
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
}