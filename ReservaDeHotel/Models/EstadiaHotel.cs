using System;
using System.ComponentModel.DataAnnotations;

namespace ReservaDeHotel.Models;

public class Estadia
{
    public int qtdQuartos { get; set; }
    public DateTime DataEntrada { get; set; }
    public DateTime DataSaida { get; set; }

    private int QtdQuartos;

    public Estadia()
    {
        
    }
    public Estadia(int qtdQuartos, DateTime dataEntrada, DateTime dataSaida)
    {
        this.qtdQuartos = qtdQuartos;
        DataEntrada = dataEntrada;
        DataSaida = dataSaida;
    }
}