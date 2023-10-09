using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;
public class Avaliacao
{
    [Key]
    public int IdAvaliacao {get;set;}
    public int IdHotel { get; set;} // tem que ver como faz ele receber o IdHotel
    public int AvaliacaoEstrelas { get; set;}
    public string? Comentario { get; set;}
    public DateTime DataAvaliacao { get; set;}
}
