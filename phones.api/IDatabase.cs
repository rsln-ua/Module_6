using phones.api.Entities;

namespace phones.api;

public interface IDatabase
{
    List<PhoneEntity> PhoneList { get; set; }
}