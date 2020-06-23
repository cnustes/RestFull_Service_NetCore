using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Models;
using Northwind.BusinessLogic.Interfaces;

namespace WebApi.Controllers
{
    [Route("api/Customer")]
    [Authorize]
    public class CustomerController: Controller
    {
        private readonly ICustomerLogic _logic;
        public CustomerController(ICustomerLogic logic)
        {
            this._logic = logic;
        }

        [HttpGet]
        [Route("{id:int}")]
        public IActionResult GetById(int id)
        {
            return Ok(_logic.GetById(id));
        }

        [HttpPost]
        public IActionResult Post([FromBody]Customer customer)
        {
            if (!ModelState.IsValid) return BadRequest();
            return Ok(_logic.Insert(customer));
        }

        [HttpPut]
        public IActionResult Put([FromBody]Customer customer)
        {
            if (ModelState.IsValid && _logic.Update(customer))
            {
                return Ok(new { Message = "The customer has been update sucessfully" });
            }
            return BadRequest(new { Message = "Has ocurred during the customer updated" });
        }

        [HttpDelete]
        public IActionResult Delete([FromBody]Customer customer)
        {
            if (customer.Id > 0)
            {
                return Ok(_logic.Delete(customer));
            }
            return BadRequest(new { Message = "Has ocurred during the customer deleted" });
        }

        [HttpGet]
        [Route("GetPaginatedCustomer/{page:int}/{rows:int}")]
        public IActionResult GetPaginatedCustomer(int page, int rows)
        {
            return Ok(_logic.CustomerPagedList(page, rows));
        }
    }
}
