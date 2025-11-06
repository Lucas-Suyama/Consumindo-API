using System.Text.Json.Serialization;

namespace Consumindo_API.Modelos;

public class Musica
{
  private string[] tonalidades = { "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };

  [JsonPropertyName("song")]
  public string? Nome { get; set; }

  [JsonPropertyName("artist")]
  public string? Artista { get; set; }

  [JsonPropertyName("duration_ms")]  
  public int? Duracao { get; set; }

  [JsonPropertyName("genre")]
  public string? Genero { get; set; }
  [JsonPropertyName("key")]
  public int key { get; set; }

  public string Tonalidade {
    get {
      return tonalidades[key];
    }
  }

  public void ExibirDetalhes()
  {
    Console.WriteLine($"Nome: {Nome}");
    Console.WriteLine($"Artista: {Artista}");
    Console.WriteLine($"Duração: {Duracao}");
    Console.WriteLine($"Gênero: {Genero}");
    Console.WriteLine($"Tonalidade: {Tonalidade}");
  }
}