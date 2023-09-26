using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ReservaHotel.Models;

public class HistoricoReserva
{
    [Key]
    public string? Nome { get; set; }
    public string? Descricao { get; set; }
}