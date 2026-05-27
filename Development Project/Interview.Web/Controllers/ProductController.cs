using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview.Web.Controllers
{
    [Route("api/v1/products")]
    public class ProductController : Controller
    {
        // NOTE: Sample Action
        [HttpGet]
        public Task<IActionResult> GetAllProducts()
        {
            return Task.FromResult((IActionResult)Ok(new object[] { }));
        }

        [HttpPost]
        public Task<IActionResult> Add(string ProductName, string ProductDesc, string ProductImage, string ProductSku)
        {
            //EVAL:  Add Product Record

            StringBuilder sb = new StringBuilder();

            if (ProductName == null) { sb.AppendLine("Product Name is Required."); }
            if (ProductDesc == null) { sb.AppendLine("Product Description is Required."); }
            if (ProductImage == null) { sb.AppendLine("Product Image is Required."); }
            if (ProductSku == null) { sb.AppendLine("Product SKU is Required."); }

            if (ProductName.Length > 256) { sb.AppendLine("Product Name Length is Invalid"); }
            if (ProductDesc.Length > 256) { sb.AppendLine("Product Description Length is Invalid"); }

            if (sb.Length > 0)
            {
                return Task.FromResult((IActionResult)BadRequest(new { message = sb.ToString() }));
            }
            else
            {
                //@@TODO:  Insert Product into Products table
                //ProductName;      //@Name
                //ProductDesc;      //@Description
                //ProductImage;     //@ProductImageUris
                //ProductSku;       //@ValidSkus
                //DateTime.Now;     //@CreatedTimestamp

                //Return Product ID
                int ProductID = 0;
                return Task.FromResult((IActionResult)Ok(new { id = ProductID }));

            }
        }
    }
}
