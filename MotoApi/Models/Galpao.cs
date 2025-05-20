namespace MotoApi.Models;

public class Galpao
{
    public int Id { get; set; }
    public string Nome { get; set; } = string.Empty;
    public string Logradouro { get; set; } = string.Empty;
    public string? Numero { get; set; }
    public string Estado { get; set; } = string.Empty;
    public string Cidade { get; set; } = string.Empty;
    public string? Regiao { get; set; }
    public int CapacidadeMax { get; set; }
    public int CapacidadeAtual { get; set; }
    public ICollection<Area>? Areas { get; set; }
}
