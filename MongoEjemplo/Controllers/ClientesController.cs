using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using MongoDB.Bson;
using MongoDB.Driver;
using MongoEjemplo.Models;

namespace MongoEjemplo.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{

    private readonly ILogger<ClientesController> _logger;
     private readonly IMongoCollection<Clientes> clientesMongo;

    public ClientesController(ILogger<ClientesController> logger,IOptions<MongoDBSettings>  mongoDBSettings)
    {
        _logger = logger;
        MongoClient client = new MongoClient(mongoDBSettings.Value.ConnectionURI);
        IMongoDatabase database = client.GetDatabase(mongoDBSettings.Value.DatabaseName);
        clientesMongo = database.GetCollection<Clientes>(mongoDBSettings.Value.CollectionName);

    }

    [HttpGet(Name = "Clientes")]
    public IEnumerable<Clientes> Get()
    {

       return clientesMongo.Find(new BsonDocument()).ToList();


    }
}
