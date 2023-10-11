using Microsoft.AspNetCore.Mvc;
using MongoEjemplo.Models;

namespace MongoEjemplo.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientesController : ControllerBase
{

    private readonly ILogger<ClientesController> _logger;

    public ClientesController(ILogger<ClientesController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "Clientes")]
    public IEnumerable<Clientes> Get()
    {
        List<Clientes> lista= new List<Clientes>();
        Clientes c1= new Clientes();
        c1.Dni="1";
        c1.Nombre="pedro";
        c1.Apellidos="gomez";
        c1.Edad=20;


        lista.Add(c1);
        return lista;


    }
}
