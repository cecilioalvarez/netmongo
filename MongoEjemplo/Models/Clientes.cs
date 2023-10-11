using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace MongoEjemplo.Models;

[BsonIgnoreExtraElements]
public class Clientes
{

    [BsonId]
    //[BsonRepresentation(BsonType.ObjectId)]
    public int  Id { get; set; }
    [BsonElement("dni")]
    public string Dni { get; set; } = null!;
    [BsonElement("nombre")]
    public string Nombre { get; set; } = null!;

    [BsonElement("apellidos")]
    public string Apellidos { get; set; } = null!;

    [BsonElement("edad")]
    public int Edad { get; set; }



}