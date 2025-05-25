using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Interface
{
    public interface IProductCategory
    {
        CommMessage_Modal ADD(ProductCategory p);
        CommMessage_Modal Edit(ProductCategory p);
        CommMessage_Modal Delete(ProductCategory p);

        List<ProductCategory> list(string srch );


    }
}
