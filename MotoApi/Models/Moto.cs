namespace MotoApi.Models;

public class Moto
{
    public int Id { get; set; }
    public string Placa { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public int Ano { get; set; }
    public string Status { get; set; } = string.Empty; // ativo, inativo
    public string Disponibilidade { get; set; } = string.Empty; // disponivel, indisponivel
    public int ClienteId { get; set; }
    public Cliente? Cliente { get; set; }
    public int? VagaId { get; set; }
    public Vaga? Vaga { get; set; }
}
