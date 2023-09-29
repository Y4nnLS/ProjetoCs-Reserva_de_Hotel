using ReservaDeHotel.Models;
using Microsoft.EntityFrameworkCore;

namespace ReservaDeHotel.Data;
public class HotelDbContext : DbContext
{
    public DbSet<Cidade>? Cidade { get; set;}
    public DbSet<Pagamento>? Pagamento { get; set;}
    public DbSet<Avaliacao>? Avaliacao { get; set;}

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("DataSource=bancoGeral.db;Cache=Shared");
    }

}