using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Web.Controllers
{
    [Route("api/v1/productcategories")]
    public class ProductCategoryController : Controller
    {
        [HttpPost]
        public Task<IActionResult> AddMultiple(int ProductID, List<int> ProductCategories)
        {
            //EVAL:  Add multiple product categories

            if (ProductID == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Product ID is Required" }));
            }
            if (ProductCategories == null || ProductCategories.Count == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Product Category List is Empty" }));
            }

            foreach (int ProductCategoryID in ProductCategories)
            {
                Add(ProductID, ProductCategoryID);
            }

            return Task.FromResult((IActionResult)Ok(new { message = "Product Categories added successfully" }));
        }

        [HttpPost]
        public Task<IActionResult> Add(int ProductID, int CategoryID)
        {
            //EVAL:  Create an individual product category

            //Validate that the Product ID & Category ID are valid
            if (ProductID == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Product ID is Required" }));
            }
            if (CategoryID == 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = "Category ID is Required" }));
            }

            //@@TODO:  Insert Product Category into ProductCategories table
            //ProductID;        //@InstanceID
            //CategoryID;       //@CategoryInstanceId


            //Return OK result after successful submission
            return Task.FromResult((IActionResult)Ok(new { message = "Product Category added successfully" }));
        }
    }
}
