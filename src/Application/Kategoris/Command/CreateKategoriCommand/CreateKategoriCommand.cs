using CleanArchitecture.Domain.Entities;
using CleanArchitecture.Application.Common.Interfaces;
using MediatR;

namespace CleanArchitecture.Application.Kategoris.Commands.CreateKategoriCommand;

public record CreateKategoriCommand : IRequest<Guid>
{
    public string? Name { get; set; }
}


public class CreateKategoriCommandHandler : IRequestHandler<CreateKategoriCommand, Guid>
{
    private readonly IApplicationDbContext _context;

    public CreateKategoriCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Guid> Handle(CreateKategoriCommand request, CancellationToken cancellationToken)
    {
        var entity = new Kategori
        {
            Name = request.Name
        };


        _context.Kategoris.Add(entity);

        await _context.SaveChangesAsync(cancellationToken);

        return entity.Id;
    }
}