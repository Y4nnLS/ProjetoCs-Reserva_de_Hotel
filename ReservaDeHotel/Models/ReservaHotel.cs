using System;
using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models
{
    public class ReservaHotel
    {
        [Key]
        public int IdReserva { get; set; }
        public string NomeHospede { get; set; }
        public string? MetodoPagamento { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataEntrada { get; set; }
        public DateTime DataSaida { get; set; }
        public int QtdQuartos { get; set; }

        public ReservaHotel(int idReserva, string nomeHospede, string metodoPagamento, int qtdQuartos, DateTime dataEntrada, DateTime dataSaida)
        {
            IdReserva = idReserva;
            NomeHospede = nomeHospede;
            MetodoPagamento = metodoPagamento;
            QtdQuartos = qtdQuartos;
            DataEntrada = dataEntrada;
            DataSaida = dataSaida;
            Valor = CalcularValorReserva();
        }

        private decimal CalcularValorReserva()
        {
            TimeSpan periodoEstadia = DataSaida - DataEntrada;
            int diasEstadia = periodoEstadia.Days;

            decimal valorQuarto = diasEstadia * QtdQuartos; 

            return valorQuarto;
        }
    }
}
