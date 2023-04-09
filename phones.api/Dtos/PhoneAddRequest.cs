namespace phones.api.Dtos;

public class PhoneAddRequest
{
    public string Brand { get; set; } = null!;
    public string Model { get; set; } = null!;
    public decimal Price { get; set; }
}