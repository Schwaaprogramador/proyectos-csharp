[ApiController]                // 👉 marca la clase como controlador de API REST
[Route("api/[controller]")]    // 👉 define la ruta base, se reemplaza [controller] por el nombre de la clase ("productos")
public class ProductosController : ControllerBase // 👉 hereda funcionalidad básica para devolver respuestas HTTP
{
    [HttpGet]                  // 👉 este método responderá a GET /api/productos
    public IActionResult GetProductos()
    {
        return Ok(new string[] { "Mouse", "Teclado" });
    }

    [HttpPost]                 // 👉 este método responderá a POST /api/productos
    public IActionResult CrearProducto([FromBody] string nombre)
    {
        return Ok($"Producto {nombre} creado");
    }
}
