namespace phones.api.Dtos;

public class PhoneUpdateRequest
{
    public int Id { get; set; }
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public decimal Price { get; set; }
}