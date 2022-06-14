using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;
using ProductsAPI.Models;

namespace ProductsAPI.Controllers
{
    [Route("api/Controller")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly ProductContext _context;
      
        public HomeController(ProductContext context)
        {
            _context = context;

           
        }
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _context.Product.ToListAsync();

        }
        [HttpGet("id")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> GetProductById(int id)
        {
            var products = await _context.Product.FindAsync(id);
            return products == null ? NotFound() : Ok(products);
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        public async Task<IActionResult> Create(Product prod)
        {
            await _context.Product.AddAsync(prod);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetProductById), new { id = prod.Id }, prod);
        }
        [HttpPut("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Update(int id, Product prod)
        {
            if (id != prod.Id) return BadRequest();
            _context.Entry(prod).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }
        [HttpDelete("{id}")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Delete(int id)
        {
            var prodToDelete = await _context.Product.FindAsync(id);
            if (prodToDelete == null) return NotFound();
            _context.Product.Remove(prodToDelete);
            await _context.SaveChangesAsync();
            return NoContent();
        }

    }
}
