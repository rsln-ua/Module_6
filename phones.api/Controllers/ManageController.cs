using Microsoft.AspNetCore.Mvc;
using phones.api.Dtos;
using phones.api.Entities;
using phones.api.Services.Abstractions;

namespace phones.api.Controllers;

[ApiController]
[Route("[controller]")]
public class ManageController : ControllerBase
{
    private readonly ILogger<ManageController> _logger;
    private readonly IPhonesService _phonesService;

    public ManageController(ILogger<ManageController> logger, IPhonesService phonesService)
    {
        _logger = logger;
        _phonesService = phonesService;
    }

    [HttpGet]
    public IEnumerable<PhoneEntity> Get()
    {
        return _phonesService.GetAllPhones();
    }

    [HttpPost]
    public int Add([FromBody] PhoneAddRequest data)
    {
        return _phonesService.AddPhone(data.Brand, data.Model, data.Price);
    }

    [HttpPut]
    public int Update([FromBody] PhoneUpdateRequest data)
    {
        return _phonesService.UpdatePhone(data.Id, data.Brand, data.Model, data.Price);
    }

    [HttpDelete]
    public int Delete([FromBody] PhoneDeleteRequest data)
    {
        return _phonesService.DeletePhone(data.Id);
    }
}