# 🎵 Consumindo API de Músicas - C#

Um projeto em C# que consome uma API de músicas e demonstra o uso de LINQ para filtrar e ordenar dados musicais.

## 📋 Descrição

Este projeto foi desenvolvido durante um curso da Alura, é uma aplicação console em C# que consome dados de músicas de uma API pública e implementa diversas funcionalidades de filtragem utilizando LINQ (Language Integrated Query). O projeto foi desenvolvido como parte do curso de C# da Alura.

## 🚀 Funcionalidades

- **Consumo de API**: Busca dados de músicas em formato JSON
- **Filtros com LINQ**:
  - Filtrar músicas por tonalidade (ex: músicas em C#)
  - Filtrar todos os gêneros musicais disponíveis
  - Filtrar artistas por gênero musical
  - Filtrar músicas por artista
  - Listar artistas ordenados
- **Gerenciamento de Músicas Favoritas**: Sistema para salvar e exibir músicas preferidas
- **Exportação JSON**: Geração de arquivos JSON com músicas favoritas

## 🛠️ Tecnologias Utilizadas

- **C# 9.0** com .NET 9.0
- **HttpClient** para consumo de API
- **System.Text.Json** para serialização/deserialização JSON
- **LINQ** para consultas e filtros de dados
- **Namespaces e Classes** para organização do código

## 📁 Estrutura do Projeto

```
Consumindo-API/
├── Modelos/
│   ├── Musica.cs              # Classe modelo para dados musicais
│   └── MusicasPreferidas.cs   # Classe para gerenciar músicas favoritas
├── Filtros/
│   ├── LinqFilter.cs          # Métodos de filtragem com LINQ
│   └── LinqOrder.cs           # Métodos de ordenação com LINQ
├── Program.cs                 # Ponto de entrada da aplicação
├── Consumindo-API.csproj      # Arquivo de configuração do projeto
└── README.md                   # Este arquivo
```

## 🎯 Modelo de Dados

A aplicação trabalha com músicas que possuem as seguintes propriedades:
- **Nome** da música
- **Artista**
- **Duração** (em milissegundos)
- **Gênero** musical
- **Tonalidade** (calculada a partir da chave)

## 🔧 Como Executar

### Pré-requisitos
- .NET 9.0 SDK instalado
- Conexão com internet (para consumir a API)

### Passos
1. Clone o repositório
2. Navegue até a pasta do projeto
3. Execute o comando:
   ```bash
   dotnet run
   ```

## 📊 Exemplos de Uso

O projeto demonstra diversas operações com LINQ:

```csharp
// Filtrar músicas em C#
var musicasEmCSharp = musicas.Where(musica => musica.Tonalidade.Equals("C#"));

// Filtrar artistas por gênero
var artistasPop = musicas.Where(musica => musica.Genero.Contains("pop"))
                         .Select(musica => musica.Artista)
                         .Distinct();

// Listar todos os gêneros disponíveis
var generos = musicas.Select(musica => musica.Genero).Distinct();
```

## 📚 API Utilizada

O projeto consome dados da API: `https://guilhermeonrails.github.io/api-csharp-songs/songs.json`

## 📝 Observações

- O projeto utiliza convenções de nomenclatura em português
- Implementa tratamento de exceções para requisições HTTP
- Utiliza propriedades com atributos JSON para mapeamento correto dos dados
- O código está organizado em namespaces separados por funcionalidade

## 🤝 Contribuições

Este projeto foi desenvolvido como parte do curso de C# da Alura. Sinta-se à vontade para explorar e aprender com o código!
Intrutores:
- Daniel Portugal
- Guilherme Lima

---

**Desenvolvido com ❤️ em C#**