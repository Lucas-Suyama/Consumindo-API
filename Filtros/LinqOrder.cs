using System.Linq;
using Consumindo_API.Modelos;
using Consumindo_API.Filtros;
using System.Collections.Generic;
using System;

namespace Consumindo_API.Filtros;

internal class LinqOrder
{
  public static void ExibirListaDeArtistasOrdenados(List<Musica> musicas)
  {
    var artistasOrdenados = musicas.OrderBy(musica => musica.Artista).Select(musica => musica.Artista).Distinct().ToList();
    artistasOrdenados.ForEach(Console.WriteLine);
  }
}
