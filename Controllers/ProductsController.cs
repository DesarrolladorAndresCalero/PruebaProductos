using Microsoft.AspNetCore.Mvc;
using PruebaProductos.Models;

namespace PruebaProductos.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private static List<Product> _products = new List<Product>();
        private static int _nextId = 1;

        //Metodo para consultar los productos existentes
        [HttpGet]
        public ActionResult<IEnumerable<Product>> GetAll()
        {
            return Ok(_products);
        }

        //Metodo para consultar producto por ID
        [HttpGet("{id}")]
        public ActionResult<Product> GetById(int id)
        {
            //Buscamos en la lista de productos cuando el id sea igual al ingresado
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

        //Metodo para crear un nuevo producto
        [HttpPost]
        public ActionResult<Product> Create(Product product)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //Agrego el producto ya con sus respectivas validaciones
            product.Id = _nextId++;
            _products.Add(product);
            return CreatedAtAction(nameof(GetById), new { id = product.Id }, product);
        }

        //Metodo para actualizar un producto por id
        [HttpPut("{id}")]
        public IActionResult Update(int id, Product updatedProduct)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            //Buscamos el producto por el id y luego reemplazamos los valores
            var existing = _products.FirstOrDefault(p => p.Id == id);
            if (existing == null)
                return NotFound();

            existing.Name = updatedProduct.Name;
            existing.Price = updatedProduct.Price;
            existing.Quantity = updatedProduct.Quantity;

            return NoContent();
        }

        //Metodo para eliminar un producto por id
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            //Buscamos el producto por el id y lo eliminamos
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
                return NotFound();

            _products.Remove(product);
            return NoContent();
        }
    }
}
