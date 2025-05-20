namespace MotoApi.DTOs;

public class VagaCreateDto
{
    public int CorredorId { get; set; }
    public string CodigoVaga { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
}
