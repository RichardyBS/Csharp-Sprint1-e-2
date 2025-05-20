namespace MotoApi.Models;

public class Corredor
{
    public int Id { get; set; }
    public int AreaId { get; set; }
    public string NomeCorredor { get; set; } = string.Empty;
    public Area? Area { get; set; }
    public ICollection<Vaga>? Vagas { get; set; }
}
