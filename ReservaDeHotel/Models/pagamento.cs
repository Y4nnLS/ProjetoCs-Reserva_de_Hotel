using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;
public class Pagamento
{
    [Key]
    public int IdPagamento {get;set;}
    public int IdReservaEstadia { get; set;}
    public string? MetodoPagamento { get; set;}
    public decimal Valor { get; set;} // o calculo pra valor seria pegar u preco por noite e multiplicar pelo tamanho da estadia
    // na model ReservaHotel o yang criou a função 'CalcularValorReserva()', podemos jogar ela pra essa model e tirar de lá
    public DateTime DataPagamento { get; set;}
}
