using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SuperHeroes.Data;
using SuperHeroes.models;

namespace SuperHeroes.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SuperHeroController : ControllerBase
{
    DataContext dataContext;
    public SuperHeroController(DataContext dataContext) {
        this.dataContext = dataContext;
    }
    [HttpGet]
    public async Task<IActionResult> getHeroes()
    {
        var heroes = dataContext.SuperHeroes.ToList();
        return Ok(heroes);
    }

    [HttpPost]
    public async Task<IActionResult> addHeo([FromBody] SuperHero newSh)
    {
        var sh = dataContext.SuperHeroes;
        await sh.AddAsync(newSh);
        dataContext.SaveChanges();
        return Ok(newSh);
    }
}

 
