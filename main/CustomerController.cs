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

    [HttpPut("{id}")]
    public IActionResult UpdateCustomers(int id,[FromBody]Customer c){
        var updateCustomerInfo = Store.customers.FirstOrDefault(customer=>customer.Id==id);

        if(updateCustomerInfo==null){
            return NotFound();
        }

        updateCustomerInfo.Name = c.Name;

        return Ok("updated information");
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCustomers(int id){
        var deleteCustomer = Store.customers.FirstOrDefault(customer=>customer.Id==id);

        if (deleteCustomer==null){
            return NotFound();
        }

        Store.customers.Remove(deleteCustomer);
        return Ok("deleted");
    }
}