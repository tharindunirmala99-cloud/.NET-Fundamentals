using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;

namespace MyFirstApi.Controllers

{

    [ApiController]

    [Route("api/[controller]")]

    public class ProductsController : ControllerBase

    {

        //---------------------------- GET All
        [HttpGet]

        public ActionResult<List<string>> Get()

        {

            return new List<string> { "Apple", "Banana", "Orange" };

        }

        //---------------------------- GET Featured
        [HttpGet("featured")]

        public string GetFeaturedProduct() => "Mango";


        //---------------------------- POST
        [HttpPost]

        public ActionResult<string> Post([FromBody] string newProduct)

        {

            return $"Added: {newProduct}";

        }

        //---------------------------- PUT
        [HttpPut("{id}")]

        public ActionResult<string> Put(int id, [FromBody] string updatedProduct)

        {

            return $"Updated product {id} to: {updatedProduct}";

        }

        //---------------------------- DELETE
        [HttpDelete("{id}")]

        public ActionResult<string> Delete(int id)

        {

            return $"Deleted product with ID: {id}";

        }

    }



}