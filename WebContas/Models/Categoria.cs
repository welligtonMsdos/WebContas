using System.Text.Json.Serialization;

namespace WebContas.Models;

public class Categoria
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("descricao")]
    public string? Descricao { get; set; }   
}
