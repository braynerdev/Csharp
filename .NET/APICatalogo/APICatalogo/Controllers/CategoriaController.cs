using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CategoriaController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Categorias>> Get()
        {
            try
            {
                var categorias = _context.Categorias.AsNoTracking();

                if (categorias is null)
                {
                    return NotFound("Nenhuma categoria encontrada");
                }
                return Ok(categorias.ToList());
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
           
        }

        [HttpGet("{id:int}", Name = "ObterCategoria")]
        public ActionResult Get(int id)
        {
            try
            {
                var categoria =
                _context
                .Categorias
                .AsNoTracking()
                .FirstOrDefault(c => c.CategoriaId == id);

                if (categoria is null)
                {
                    return NotFound("Categoria não existe!");
                }

                return Ok(categoria);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpGet("produtos")]
        public ActionResult<IEnumerable<Categorias>> GetCategoriaProduto()
        {
            try
            {
                var categorias = _context.Categorias.AsNoTracking();
                if (categorias is null)
                {
                    return NotFound("Categoria não existe");
                }
                return categorias.Include(p => p.Produtos).ToList();
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }


        [HttpPost]
        public ActionResult Post(Categorias categoria)
        {
            try
            {
                if (categoria is null)
                {
                    return BadRequest("Categoria invalida!");
                }
                _context.Categorias.Add(categoria);
                _context.SaveChanges();

                return Ok(new CreatedAtRouteResult("ObterCategoria",
                    new { id = categoria.CategoriaId }, categoria));
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Categorias categoria)
        {
            try
            {
                if (id != categoria.CategoriaId)
                {
                    return BadRequest("Informações invalidas");
                }
                var cat =
                    _context
                    .Categorias
                    .AsNoTracking()
                    .FirstOrDefault(c => c.CategoriaId == id);
                if (cat is null)
                {
                    return NotFound("Categoria não existe!");
                }

                _context.Entry(categoria).State = EntityState.Modified;
                _context.SaveChanges();
                return Ok(cat);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpDelete("{id:int}", Name = "DeleteCategoria")]
        public ActionResult<string> Delete(int id)
        {
            try
            {
                var categoria =
               _context
               .Categorias
               .FirstOrDefault(c => c.CategoriaId == id);

                if (categoria is null)
                {
                    return NotFound("Categoria não existe!");
                }

                _context.Categorias.Remove(categoria);
                _context.SaveChanges();

                return Ok(categoria);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
           
        }
    }
}
