using System.ComponentModel.DataAnnotations;

namespace CleanArchitecture.Domain.Entities;

public class  KatMobil
{
    [Key]
    public Guid Id {get; set;}
    public string Nama { get; set;}
    public decimal Harga { get; set;}
    public int Km { get; set;}
    public int TahunProduksi { get ; set;}
    public string Image { get; set;}

    public Kategori Kategori { get; set;}
    public Guid KategoriId { get; set;}

}