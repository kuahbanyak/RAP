using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities;

public class Kategori
{
    [Key]
    public Guid Id { get; set; }
    public string? Name { get; set; }

}