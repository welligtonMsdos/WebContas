using System.Text.Json.Serialization;

namespace WebContas.Models;

public class Conta
{
    [JsonPropertyName("id")]
    public int? Id { get; set; }

    [JsonPropertyName("descricao")]
    public string? Descricao { get; set; }

    [JsonPropertyName("valor")]
    public decimal? Valor { get; set; }
}
