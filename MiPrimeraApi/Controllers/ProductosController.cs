using Microsoft.AspNetCore.Mvc;

namespace MiApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductosController : ControllerBase
    {
        private static List<string> productos = new List<string> { "Laptop", "Mouse", "Teclado" };

        [HttpGet]
        public ActionResult<IEnumerable<string>> GetProductos()
        {
            return Ok(productos);
        }

        [HttpGet("{id}")]
        public ActionResult<string> GetProducto(int id)
        {
            if (id < 0 || id >= productos.Count)
                return NotFound();

            return Ok(productos[id]);
        }

        [HttpPost]
        public ActionResult CrearProducto([FromBody] string nuevoProducto)
        {
            productos.Add(nuevoProducto);
            return CreatedAtAction(nameof(GetProducto), new { id = productos.Count - 1 }, nuevoProducto);
        }

        [HttpDelete("{id}")]
        public ActionResult EliminarProducto(int id)
        {
            if (id < 0 || id >= productos.Count)
                return NotFound();

            productos.RemoveAt(id);
            return NoContent();
        }
    }
}
