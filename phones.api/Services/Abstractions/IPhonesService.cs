using phones.api.Entities;

namespace phones.api.Services.Abstractions;

public interface IPhonesService
{
    int AddPhone(string brand, string model, decimal price, int? id = null);
    int DeletePhone(int id);
    int UpdatePhone(int id, string brand, string model, decimal price);
    List<PhoneEntity> GetAllPhones();
}