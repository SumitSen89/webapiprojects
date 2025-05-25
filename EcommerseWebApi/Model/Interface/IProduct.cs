using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Interface
{
    public interface IProduct
    {
        CommMessage_Modal ADD(Product p);
        CommMessage_Modal Edit(Product p);
        CommMessage_Modal Delete(Product p);

        List<Product> list(string srch);

        ProductDetails GetProductDetails(int id);
        CommMessage_Modal Add_SpecificationType(int ProductID, int SpecificationTypeID);
        CommMessage_Modal Edit_SpecificationType(int ProductID, int O_SpecificationTypeID, int N_SpecificationTypeID);
        CommMessage_Modal Delete_SpecificationType(int ProductID, int SpecificationTypeID);


        CommMessage_Modal Add_SpecificationTypeSpefication(int ProductID, int SpecificationTypeID, int SpecificationID);
        CommMessage_Modal Edit_SpecificationTypeSpefication(int ProductID, int SpecificationTypeID, int OSpecificationID, int N_SpecificationID);
        CommMessage_Modal Delete_SpecificationTypeSpefication(int ProductID, int SpecificationTypeID, int SpecificationID);
    }
}
