using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;
public class Hotel
{
    [Key]
    public int IDHotel { get; set; }
    public string? Nome { get; set; }
    public string? Endereco { get; set; }
    public int Classificacao { get; set; } // ele n receberia uma lista de Avaliação?
    public string? Descricao { get; set; }
    public string? ListaDeQuartos { get; set; }
    public double AvaliacaoMedia { get; set; } // aqui seria somar as avaliações e dividir pra tirar a média
    public int IdDoDono { get; set; }
    public int NumeroTotalDeQuartos { get; set; } // soma da quantidade de quartos existentes
    public int NumeroDeQuartosDisponiveis { get; set; } // pega a lista de quartos e subtrai aqueles que estão ocupados
}
