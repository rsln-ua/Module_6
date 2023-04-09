using phones.api.Entities;

namespace phones.api;

public class SuperDataBase: IDatabase
{
    public List<PhoneEntity> PhoneList { get; set; } = new();
}