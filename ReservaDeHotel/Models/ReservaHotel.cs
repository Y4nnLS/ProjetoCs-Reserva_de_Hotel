using System;
using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models
{
    public class ReservaHotel : Estadia
    {
        [Key]
        public int IdReserva { get; set; }
        public string NomeHospede { get; set; }
        public string? MetodoPagamento { get; set; }
        public decimal Valor { get; private set; }
        public Estadia Estadia { get; set; }

        public ReservaHotel(int idReserva, string nomeHospede, string metodoPagamento, int qtdQuartos, DateTime dataEntrada, DateTime dataSaida)
        {
            IdReserva = idReserva;
            NomeHospede = nomeHospede;
            MetodoPagamento = metodoPagamento;
            
            Estadia = new Estadia(qtdQuartos, dataEntrada, dataSaida);

            CalcularValorReserva();
        }

        private void CalcularValorReserva()
        {
            TimeSpan periodoEstadia = DataSaida - DataEntrada;
            int diasEstadia = periodoEstadia.Days;

            Valor = diasEstadia * Estadia.qtdQuartos; 
        }
    }
}
