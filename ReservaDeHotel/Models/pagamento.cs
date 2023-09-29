using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;
public class Pagamento
{
    [Key]
    public int IdPagamento {get;set;}
    public int IdReservaEstadia { get; set;}
    public string? MetodoPagamento { get; set;}
    public float Valor { get; set;}
    public DateTime DataPagamento { get; set;}
}
