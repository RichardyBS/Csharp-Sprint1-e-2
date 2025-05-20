namespace MotoApi.DTOs;

public class MotoCreateDto
{
    public string Placa { get; set; } = string.Empty;
    public string Modelo { get; set; } = string.Empty;
    public string Marca { get; set; } = string.Empty;
    public int Ano { get; set; }
    public string Status { get; set; } = string.Empty;
    public string Disponibilidade { get; set; } = string.Empty;
    public int ClienteId { get; set; }
    public int? VagaId { get; set; }
}
