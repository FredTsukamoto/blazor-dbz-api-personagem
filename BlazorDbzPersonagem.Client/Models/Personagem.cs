using System.Text.Json.Serialization;

namespace BlazorDbzPersonagem.Client.Models;

public class Personagem
{
    [JsonPropertyName("id")]
    public int Id { get; set; }

    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;

    [JsonPropertyName("originPlanet")]
    public Planeta? OriginPlanet { get; set; }

    [JsonPropertyName("transformations")]
    public List<Transformacao> Transformations { get; set; } = new();
}

public class Planeta
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}

public class Transformacao
{
    [JsonPropertyName("name")]
    public string Name { get; set; } = string.Empty;
}