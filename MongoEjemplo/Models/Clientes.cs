using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoEjemplo.Models;

public class Clientes {

    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }

    public string Dni { get; set; } = null!;
    
    public string Nombre { get; set; } = null!;
    
    public string Apellidos { get; set; } = null!;
    
    public string Edad { get; set; } = null!;



}