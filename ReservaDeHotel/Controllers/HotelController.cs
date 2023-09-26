using ReservaHotel.Data;
using ReservaHotel.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SQLitePCL;

namespace ReservaHotel.Controllers;
[ApiController]
[Route("[controller]")]
public class HotelController : ControllerBase
{
    private HotelDbContext _dbContext;
    public HotelController(HotelDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    [HttpPost]
    [Route("cadastrar")]
    public async Task<ActionResult> Cadastrar(Hotel hotel)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hotel is null) return NotFound();
        await _dbContext.AddAsync(hotel);
        await _dbContext.SaveChangesAsync();
        return Created("",hotel);
    }

    [HttpGet]
    [Route("listar")]
    public async Task<ActionResult<IEnumerable<Hotel>>> Listar()
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hotel is null) return NotFound();
        return await _dbContext.Hotel.ToListAsync();
    }

    [HttpGet]
    [Route("buscar/{nome}")]
    public async Task<ActionResult<Hotel>> Buscar(string nome)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hotel is null) return NotFound();
        var hotelTemp = await _dbContext.Hotel.FindAsync(nome);
        if(hotelTemp is null) return NotFound();
        return hotelTemp;
    }

    [HttpPut()]
    [Route("alterar")]
    public async Task<ActionResult> Alterar(Hotel hotel)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hotel is null) return NotFound();
        var hotelTemp = await _dbContext.Hotel.FindAsync(hotel.Nome);
        if(hotelTemp is null) return NotFound();       
        _dbContext.Hotel.Update(hotel);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

    [HttpPatch()]
    [Route("mudardescricao/{nome}")]
    public async Task<ActionResult> MudarDescricao(string nome, [FromForm] string descricao)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hotel is null) return NotFound();
        var hotelTemp = await _dbContext.Hotel.FindAsync(nome);
        if(hotelTemp is null) return NotFound();
        hotelTemp.Descricao = descricao;
        await _dbContext.SaveChangesAsync();
        return Ok();
    }
    [HttpDelete()]
    [Route("excluir/{nome}")]
    public async Task<ActionResult> Excluir(string nome)
    {
        if(_dbContext is null) return NotFound();
        if(_dbContext.Hotel is null) return NotFound();
        var hotelTemp = await _dbContext.Hotel.FindAsync(nome);
        if(hotelTemp is null) return NotFound();
        _dbContext.Remove(hotelTemp);
        await _dbContext.SaveChangesAsync();
        return Ok();
    }

}