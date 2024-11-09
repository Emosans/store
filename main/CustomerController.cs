using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/customers")]

public class CustomerController : ControllerBase{
    [HttpGet]
    public IActionResult GetCustomers(){
        return Ok(Store.customers);
    }

    [HttpPost]
    public IActionResult PostCustomers([FromBody]Customer c){
        c.Id = Store.customers.Count+1;

        Store.customers.Add(c);

        return Ok("Added customer");
    }
}