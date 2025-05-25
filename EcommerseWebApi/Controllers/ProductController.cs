using EcommerseWebApi.Model.Implementation;
using EcommerseWebApi.Model.Interface;
using EcommerseWebApi.Model.Table;
using Microsoft.AspNetCore.Mvc;

namespace EcommerseWebApi.Controllers
{
    public class ProductController : Controller
    {
        IProduct product;
        public ProductController(IProduct _product)
        {
            product = _product;
        }

        [HttpPost]
        public CommMessage_Modal AddProduct([FromBody] Product _product)
        {
            return product.ADD(_product);       

        }

        [HttpGet]
        public ProductDetails GetProductDetails(int _product)
        {
            return product.GetProductDetails(_product);
        }

        [HttpPost]
        public CommMessage_Modal AddProductSpeficationType(int ProductID, int SpecificationTypeID)
        {
            return product.Add_SpecificationType(ProductID, SpecificationTypeID);
        }

        [HttpPost]
        public CommMessage_Modal AddProductSpeficationTypeSpefication(int ProductID, int SpecificationTypeID, int SpecificationID)
        {
            return product.Add_SpecificationTypeSpefication(ProductID, SpecificationTypeID, SpecificationID);
        }
    }
}
