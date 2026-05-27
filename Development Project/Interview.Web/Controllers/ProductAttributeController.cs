using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Web.Controllers
{
    [Route("api/v1/productattributes")]
    public class ProductAttributeController : Controller
    {
        [HttpPost]
        public Task<IActionResult> AddMultiple(int ProductID, Dictionary<string, string> ProductAttributes)
        {
            //EVAL:  Add multiple product attributes

            if (ProductID == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Product ID is Required" }));
            }
            if (ProductAttributes == null || ProductAttributes.Count == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Product Attribute List is Empty" }));
            }

            foreach (KeyValuePair<string, string> ProductAttribute in ProductAttributes)
            {
                Add(ProductID, ProductAttribute);
            }

            return Task.FromResult((IActionResult)Ok(new { message = "Product Categories added successfully" }));
        }

        [HttpPost]
        public Task<IActionResult> Add(int ProductID, KeyValuePair<string, string> ProductAttribute)
        {
            //EVAL:  Create an individual product attribute

            //Validate that the Product ID & Category ID are valid
            if (ProductID == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Product ID is Required" }));
            }

            //@@TODO:  Insert Product Attribute into ProductAttributes table
            //ProductID;                    //@InstanceID
            //ProductAttribute.Key;         //@Key
            //ProductAttribute.Value;       //@Value

            //Return OK Message
            return Task.FromResult((IActionResult)Ok(new { message = "Product Attribute added successfully" }));
        }
    }
}
