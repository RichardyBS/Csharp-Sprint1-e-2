using Microsoft.AspNetCore.Mvc;
using MotoApi.Models;
using MotoApi.Data;

namespace MotoApi
{
    /// <summary>
    /// Controller para operações relacionadas a motos.
    /// </summary>
    [ApiController]
    [Route("api/[controller]")]
    public class MotoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MotoController(AppDbContext context)
        {
            _context = context;
        }

        /// <summary>
        /// Lista todas as motos cadastradas.
        /// </summary>
        /// <remarks>
        /// Retorna uma lista com todas as motos presentes no sistema, incluindo informações como placa, modelo, marca, ano, status, disponibilidade, cliente e vaga associada.
        /// </remarks>
        /// <response code="200">Lista de motos retornada com sucesso.</response>
        [HttpGet]
        public ActionResult<IEnumerable<Moto>> GetMotos()
        {
            return Ok(_context.Motos.ToList());
        }

        /// <summary>
        /// Busca uma moto pelo ID.
        /// </summary>
        /// <param name="id">Identificador único da moto.</param>
        /// <remarks>
        /// Retorna os dados de uma moto específica, caso exista. Se não for encontrada, retorna 404.
        /// </remarks>
        /// <response code="200">Moto encontrada com sucesso.</response>
        /// <response code="404">Moto não encontrada.</response>
        [HttpGet("{id}")]
        public ActionResult<Moto> GetMoto(int id)
        {
            var moto = _context.Motos.Find(id);
            if (moto == null) return NotFound();
            return Ok(moto);
        }

        /// <summary>
        /// Cadastra uma nova moto.
        /// </summary>
        /// <param name="moto">Objeto contendo os dados da moto a ser cadastrada.</param>
        /// <remarks>
        /// Adiciona uma nova moto ao sistema. Todos os campos obrigatórios devem ser preenchidos corretamente.
        /// </remarks>
        /// <response code="201">Moto cadastrada com sucesso.</response>
        /// <response code="400">Dados inválidos para cadastro.</response>
        [HttpPost]
        public ActionResult<Moto> PostMoto(Moto moto)
        {
            _context.Motos.Add(moto);
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetMoto), new { id = moto.Id }, moto);
        }

        /// <summary>
        /// Atualiza uma moto existente.
        /// </summary>
        /// <param name="id">Identificador único da moto.</param>
        /// <param name="moto">Objeto com os dados atualizados da moto.</param>
        /// <remarks>
        /// Atualiza os dados de uma moto já cadastrada. O ID da URL deve ser igual ao ID do objeto enviado.
        /// </remarks>
        /// <response code="204">Moto atualizada com sucesso.</response>
        /// <response code="400">ID informado não corresponde ao objeto enviado.</response>
        [HttpPut("{id}")]
        public IActionResult PutMoto(int id, Moto moto)
        {
            if (id != moto.Id) return BadRequest();
            _context.Entry(moto).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _context.SaveChanges();
            return NoContent();
        }

        /// <summary>
        /// Remove uma moto pelo ID.
        /// </summary>
        /// <param name="id">Identificador único da moto.</param>
        /// <remarks>
        /// Remove uma moto do sistema. Se não existir uma moto com o ID informado, retorna 404.
        /// </remarks>
        /// <response code="204">Moto removida com sucesso.</response>
        /// <response code="404">Moto não encontrada.</response>
        [HttpDelete("{id}")]
        public IActionResult DeleteMoto(int id)
        {
            var moto = _context.Motos.Find(id);
            if (moto == null) return NotFound();
            _context.Motos.Remove(moto);
            _context.SaveChanges();
            return NoContent();
        }
    }
}
