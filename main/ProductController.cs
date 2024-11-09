using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route ("api/products")]

public class ProductController : ControllerBase {
    [HttpGet]
    public IActionResult GetProducts(){
        return Ok(Store.products);
    }

    [HttpPost]
    public IActionResult AddProducts([FromBody]Product p){
        p.Id = Store.products.Count+1;

        Store.products.Add(p);
        return Ok("Product added");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProducts(int id){
        var product = Store.products.FirstOrDefault(p=> p.Id==id);
        if(product==null){
            return NotFound();
        }
        Store.products.Remove(product);
        return Ok("Product deleted");
    }
}