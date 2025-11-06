using System.Text.Json;
namespace Consumindo_API.Modelos;

internal class MusicasPreferidas
{
  public string? Nome { get; set; } = string.Empty;
  public List<Musica> ListaDeMusicas { get; }

  public MusicasPreferidas(string nome)
  {
    Nome = nome;
    ListaDeMusicas = new List<Musica>();
  }

  public void AdicionarMusica(Musica musica)
  {
    ListaDeMusicas.Add(musica);
  }

  public void ExibirMusicasPreferidas()
  {
    Console.WriteLine($"Músicas preferidas de {Nome}:");
    foreach (var musica in ListaDeMusicas)
    {
      Console.WriteLine($"Artista: {musica.Artista}, Música: {musica.Nome}");
    }
  }

  public void GerarArquivoJson()
  {
    var json = JsonSerializer.Serialize(ListaDeMusicas);
    File.WriteAllText($"musicas-preferidas-{Nome}.json", json);
    Console.WriteLine($"Arquivo JSON gerado: {Path.GetFullPath($"musicas-preferidas-{Nome}.json")}");
  }
}
