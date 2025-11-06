using Consumindo_API.Modelos;

using System.Linq;
namespace Consumindo_API.Filtros;

internal class LinqFilter
{
  public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
  {
    var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList();
    todosOsGenerosMusicais.ForEach(Console.WriteLine);
  }

  public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
  {
    var artistasPorGeneroMusical = musicas.Where(musica => musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList();
    artistasPorGeneroMusical.ForEach(Console.WriteLine);
  }

  public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
  {
    var musicasPorArtista = musicas.Where(musica => musica.Artista!.Equals(artista)).ToList();
    foreach (var musica in musicasPorArtista)
    {
      Console.WriteLine($"Artista: {musica.Artista}, Música: {musica.Nome}");
    }
  }

  internal static void FiltrarMusicasEmCSharp(List<Musica> musicas)
  {
    var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#")).Select(musica => musica.Nome).ToList();
    musicasEmCSharp.ForEach(Console.WriteLine);
  }
}