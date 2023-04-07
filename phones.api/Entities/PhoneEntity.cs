namespace phones.api.Entities;

public class PhoneEntity
{
    public int Id { get; set; }
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public decimal Price { get; set; }
}