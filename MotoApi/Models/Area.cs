namespace MotoApi.Models;

public class Area
{
    public int Id { get; set; }
    public int GalpaoId { get; set; }
    public string TipoArea { get; set; } = string.Empty;
    public int CapacidadeMax { get; set; }
    public int CapacidadeAtual { get; set; }
    public Galpao? Galpao { get; set; }
    public ICollection<Corredor>? Corredores { get; set; }
}
