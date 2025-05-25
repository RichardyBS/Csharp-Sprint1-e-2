namespace MotoApi.Models;

public class Vaga
{
    public int Id { get; set; }
    public int CorredorId { get; set; }
    public string CodigoVaga { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public Corredor? Corredor { get; set; }
    public ICollection<Moto>? Motos { get; set; }
}
