using System.ComponentModel.DataAnnotations;

namespace ScreenSound.API.Requests;

public record MusicaRequest([Required] string nome, [Required] int ArtistaId, int AnoLancamento,string Letra, ICollection<GeneroRequest> Generos = null );