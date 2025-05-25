using EcommerseWebApi.Model.Interface;
using EcommerseWebApi.Model.Table;
using Microsoft.AspNetCore.Mvc;

namespace EcommerseWebApi.Model.Implementation
{
    public class Imp_Product : IProduct
    {

        ApplicationDBContext db;

        public Imp_Product(ApplicationDBContext _db)
        {
            db = _db;
        }

        //public string ADD(ProductCategory P)
        //{
        //    db.ProductCategories.Add(P);
        //    db.SaveChanges();

        //    return "Success";
        //}

        public CommMessage_Modal ADD([FromBody] Product P)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                db.Products.Add(P);
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Created");

            }
            catch (Exception ex)
            {
                db.Products.Remove(P);
                return cm.RecordError(ex.InnerException.Message, "", "Test", "DatabaseMaster", "AddProductcategory", "Add");
            }

        }

        public CommMessage_Modal Delete(Product P)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                Product o = db.Products.Where(s => s.Id == P.Id).FirstOrDefault();
                db.Products.Remove(o);
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Removed");

            }
            catch (Exception ex)
            {

                return cm.RecordError(ex.InnerException.Message, "", "Test", "DatabaseMaster", "AddProductcategory", "Delete");
            }
        }

        public CommMessage_Modal Edit(Product P)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                Product o = db.Products.Where(s => s.Id == P.Id).FirstOrDefault();
                o.Title = P.Title;
                o.Description = P.Description;
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Created");

            }
            catch (Exception ex)
            {
                db.Products.Remove(P);
                return cm.RecordError(ex.InnerException.Message, "", "Test", "DatabaseMaster", "AddProductcategory", "Add");
            }

        }

        public List<Product> List(string srch)
        {
            if (srch != null)
                return db.Products.Where(s => s.Title.Contains(srch)).ToList();
            else
                return db.Products.ToList();
        }

        public List<Product> list(string srch)
        {
            throw new NotImplementedException();
        }

        public ProductDetails GetProductDetails(int id)
        {
            ProductDetails productDetails = new ProductDetails();

            productDetails.product = db.Products.Where(w => w.Id == id).FirstOrDefault();

            if (productDetails.product != null)
                productDetails.productCategory = db.ProductCategories.Where(w => productDetails.product.ProductCategoryID == w.Id).FirstOrDefault();

            

            return productDetails;
        }

        CommMessage_Modal IProduct.Add_SpecificationType(int ProductID, int SpecificationTypeID)
        {
            CommMessage cm = new CommMessage(db);
            ProductSpeficationType o = new ProductSpeficationType();
            try
            {
                o.ProductID = ProductID;
                o.SpeficationTypeID = SpecificationTypeID;
                db.ProductSpeficationTypes.Add(o);
                db.SaveChanges();
                return cm.GenerateMessage("Product Created");
            }
            catch (Exception ex)
            {
                db.ProductSpeficationTypes.Remove(o);
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "Add_SpecificationType", "Add");
            }
        }

        CommMessage_Modal IProduct.Edit_SpecificationType(int ProductID, int O_SpecificationTypeID, int N_SpecificationTypeID)
        {
            throw new NotImplementedException();
        }

        CommMessage_Modal IProduct.Delete_SpecificationType(int ProductID, int SpecificationTypeID)
        {
            throw new NotImplementedException();
        }

        CommMessage_Modal IProduct.Add_SpecificationTypeSpefication(int ProductID, int SpecificationTypeID, int SpecificationID)
        {

            // db.ProductCategories.Any();

            CommMessage cm = new CommMessage(db);
            ProductSpeficationTypeSpecification o = new ProductSpeficationTypeSpecification();
            try
            {
                o.ProductID = ProductID;
                o.SpeficationTypeID = SpecificationTypeID;
                o.SpeficationID = SpecificationID;
                db.ProductSpeficationTypeSpecifications.Add(o);
                db.SaveChanges();
                return cm.GenerateMessage("Product Speficaition Type Spe Created");
            }
            catch (Exception ex)
            {
                db.ProductSpeficationTypeSpecifications.Remove(o);
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "Add_SpecificationType", "Add");
            }
        }

        CommMessage_Modal IProduct.Edit_SpecificationTypeSpefication(int ProductID, int SpecificationTypeID, int OSpecificationID, int N_SpecificationID)
        {
            throw new NotImplementedException();
        }

        CommMessage_Modal IProduct.Delete_SpecificationTypeSpefication(int ProductID, int SpecificationTypeID, int SpecificationID)
        {
            throw new NotImplementedException();
        }
    }


}
