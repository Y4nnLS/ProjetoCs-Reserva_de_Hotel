using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ReservaDeHotel.Models
{
    public class ReservaHotel
    {
        [Key]
        public int IdReserva { get; set; }
        public string? NomeHospede { get; set; }
        public string? MetodoPagamento { get; set; }
        public decimal Valor { get; private set; }

        [ForeignKey("Estadia")]
        public int IdEstadia { get; set; }
        public EstadiaHotel? Estadia { get; set; }

        public ReservaHotel()
        {
        }

        public ReservaHotel(int idReserva, string nomeHospede, string metodoPagamento, EstadiaHotel estadia)
        {
            IdReserva = idReserva;
            NomeHospede = nomeHospede;
            MetodoPagamento = metodoPagamento;

            Estadia = estadia;
            IdEstadia = estadia.IdEstadia;

            CalcularValorReserva();
        }

        private void CalcularValorReserva()
        {
            TimeSpan periodoEstadia = Estadia.DataSaida - Estadia.DataEntrada;
            int diasEstadia = periodoEstadia.Days;

            Valor = diasEstadia * Estadia.QtdQuartos;
        }
    }
}
