namespace EcommerseWebApi.Model.Table
{
    public class Product
    {
        public int? Id { get; set; }
        public string Title { get; set; }

        public string Description { get; set; }

        public int ProductCategoryID { get; set; }

        public int DefautRate { get; set; }

    }
    public class ProductDetails
    {
        public Product product { get; set; }
        public ProductCategory productCategory { get; set; }
        public List<ProductSpeficationType_VModel> productsSpecificationType { get; set; }


    }

   

    public class ProductSpeficationTypeSpecification
    {
        public int? Id { get; set; }
        public int ProductID { get; set; }
        public int SpeficationTypeID { get; set; }
        public int SpeficationID { get; set; }

    }

    public class ProductSpeficationType
    {
        public int? Id { get; set; }
        public int ProductID { get; set; }
        public int SpeficationTypeID { get; set; }
    }

    public class ProductSpeficationType_VModel
    {
        public int SpeficationTypeID { get; set; }
        public string SpecTP { get; set; }
    }



}