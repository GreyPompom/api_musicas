namespace ScreenSound.Web.Requests;

public record MusicaRequestEdit(int Id, string nome, int ArtistaId, int anoLancamento, string letra)
    : MusicaRequest(nome, ArtistaId, anoLancamento, letra);

