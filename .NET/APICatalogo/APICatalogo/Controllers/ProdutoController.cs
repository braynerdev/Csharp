using APICatalogo.Context;
using APICatalogo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public ProdutoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Produtos>> Get()
        {
            try
            {
                var produtos = _context.Produtos;

                if (produtos is null)
                {
                    return NotFound("Produtos Não Encontrados");
                }
                return produtos;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpGet("{id:int}" , Name="ObterProduto")]
        public ActionResult<Produtos> Get(int id)
        {
            try
            {
                var produto = _context.Produtos.FirstOrDefault(p => p.ProdutoId == id);

                if (produto is null)
                {
                    return NotFound("Produto Não Encontrados");
                }
                return produto;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpPost]
        public ActionResult Post(Produtos produto)
        {
            try
            {
                if (produto is null)
                {
                    return BadRequest();
                }

                _context.Produtos.Add(produto);
                _context.SaveChanges();

                return new CreatedAtRouteResult("ObterProduto",
                    new { id = produto.ProdutoId }, produto);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Produtos produto)
        {
            try
            {
                if (id != produto.ProdutoId)
                {
                    return BadRequest("Dados Inconcistentes");
                }
                var prod =
                    _context
                    .Produtos
                    .AsNoTracking()
                    .FirstOrDefault(p => p.ProdutoId == id);
                if (prod is null)
                {
                    return NotFound("Produto Não Encontrados");
                }
                _context.Entry(produto).State = EntityState.Modified;
                _context.SaveChanges();

                return Ok(prod);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }

        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
            try
            {
                var produto =
                _context
                .Produtos
                .FirstOrDefault(p => p.ProdutoId == id);

                if (produto is null)
                {
                    return NotFound("Produto Não Encontrados");
                }

                _context.Produtos.Remove(produto);
                _context.SaveChanges();

                return Ok(produto);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Erro mo servidor");
            }
            
        }
    }
}
