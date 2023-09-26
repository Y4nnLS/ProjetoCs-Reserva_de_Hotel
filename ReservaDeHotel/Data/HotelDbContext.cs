using Microsoft.EntityFrameworkCore;
using ReservaHotel.Models;

namespace ReservaHotel.Data;

public class HotelDbContext:DbContext
{
    public DbSet <Hotel>? Hotel {get; set;}
    public DbSet <Reserva>? Reserva {get; set;}
    public DbSet <HistoricoReserva>? HistoricoReserva {get; set;}
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=Hotel.db;Cache=Shared");
    }
}