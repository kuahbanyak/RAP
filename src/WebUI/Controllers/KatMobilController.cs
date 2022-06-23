using CleanArchitecture.Application.Common.Interfaces;
using CleanArchitecture.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CleanArchitecture.WebUI.Controllers;
public class KatMobilController : ControllerBase
{
    private readonly IApplicationDbContext _context;
    public KatMobilController(IApplicationDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<List<KatMobil>>>Get(Guid kategoriId)
    {
        var katmobils = await _context.KatMobils
            .Where(c => c.KategoriId == kategoriId)
            .ToListAsync();
        return Ok(katmobils);
    }
}
