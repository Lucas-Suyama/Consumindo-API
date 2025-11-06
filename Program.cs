using System.Text.Json;
using Consumindo_API.Modelos;
using Consumindo_API.Filtros;
using (HttpClient client = new HttpClient())
{
  try
  {
    string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
    var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!;

    LinqFilter.FiltrarMusicasEmCSharp(musicas);



    //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas);
    //LinqOrder.ExibirListaDeArtistasOrdenados(musicas);
    //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "pop");
    //LinqFilter.FiltrarMusicasPorArtista(musicas, "Michel Teló");

    // var musicasPreferidas = new MusicasPreferidas("Lucas");
    // musicasPreferidas.AdicionarMusica(musicas[0]);
    // musicasPreferidas.AdicionarMusica(musicas[1]);
    // musicasPreferidas.AdicionarMusica(musicas[2]);
    // musicasPreferidas.AdicionarMusica(musicas[3]);
    // musicasPreferidas.AdicionarMusica(musicas[4]);
    
    // musicasPreferidas.ExibirMusicasPreferidas();
  }
  catch (HttpRequestException e)
  {
    Console.WriteLine($"Erro: {e.Message}");
  }
}