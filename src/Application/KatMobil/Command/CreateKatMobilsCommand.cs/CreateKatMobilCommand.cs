/*
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.KatMobils.Commands.CreateKatMobilCommand;
public record CreateKatMobilCommand
{
    public string? Nama { get; set; }
    public decimal Harga { get; set; }
    public int Km { get; set; }
     public int TahunProduksi { get; set; }

    public string? Image { get; set; }
    
    public Guid Kategoriid { get; set; }
}

public class CreateKatMobilCommandHandler  : IRequestHandler<CreateKatMobilCommand , Guid>
{
    private readonly IApplicationDbContext _context;

    public CreateKategoriCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }
    public async Task<Guid> Handle(CreateKatMobilCommand request, CancellationToken cancellationToken)
    {
        var entiy = 
    }
}
*/