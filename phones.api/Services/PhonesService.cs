using phones.api.Entities;
using phones.api.Services.Abstractions;

namespace phones.api.Services;

public class PhonesService : IPhonesService
{
    private readonly IDatabase _database;

    public PhonesService(IDatabase database)
    {
        _database = database;
    }

    public int AddPhone(string brand, string model, decimal price, int? id)
    {
        var newPhone = new PhoneEntity() { Brand = brand, Model = model, Price = price, Id = id ?? GetId() };
        _database.PhoneList.Add(newPhone);

        return newPhone.Id;
    }

    public int DeletePhone(int id)
    {
        var itemToRemove = _database.PhoneList.Single(i => i.Id == id);

        if (itemToRemove == null)
        {
            return 0;
        }

        _database.PhoneList.Remove(itemToRemove);

        return id;
    }

    public int UpdatePhone(int id, string brand, string model, decimal price)
    {
        var _id = DeletePhone(id);
        if (_id == 0)
        {
            return 0;
        }

        AddPhone(brand, model, price, id);

        return id;
    }

    public List<PhoneEntity> GetAllPhones()
    {
        return _database.PhoneList;
    }

    private int GetId()
    {
        return new Random().Next(1, int.MaxValue);
    }
}