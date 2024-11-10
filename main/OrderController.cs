using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route ("api/orders")]

public class OrderController : ControllerBase {
    [HttpGet]
    public IActionResult GetOrders(){
        return Ok(Store.orders);
    }

    [HttpPost]
    public IActionResult AddOrders([FromBody]Orders order){
        var currentorder = Store.products.FirstOrDefault(o=>o.Name == order.Name);

        if (currentorder == null){
            return NotFound();
        }
        order.Id = Store.orders.Count+1;
        Store.orders.Add(order);

        return Ok(currentorder);
    }
}