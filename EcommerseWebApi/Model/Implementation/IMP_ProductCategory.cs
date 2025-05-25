using EcommerseWebApi.Model.Interface;
using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Implementation
{
    public class IMP_ProductCategory : ProductCategory
    {
        ApplicationDBContext db;

        public IMP_ProductCategory(ApplicationDBContext _db)
        {
            db = _db;
        }

        //public string ADD(ProductCategory P)
        //{
        //    db.ProductCategories.Add(P);
        //    db.SaveChanges();

        //    return "Success";
        //}

        public CommMessage_Modal ADD(ProductCategory P)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                db.ProductCategories.Add(P);
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Created");

            }
            catch (Exception ex)
            {
                db.ProductCategories.Remove(P);
                return cm.RecordError(ex.InnerException.Message, "", "Test", "DatabaseMaster", "AddProductcategory", "Add");
            }

        }

        public CommMessage_Modal Delete(ProductCategory P)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                db.ProductCategories.Remove(P);
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Removed");

            }
            catch (Exception ex)
            {

                return cm.RecordError(ex.InnerException.Message, "", "Test", "DatabaseMaster", "AddProductcategory", "Delete");
            }
        }

        public CommMessage_Modal Edit(ProductCategory P)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                ProductCategory o = db.ProductCategories.Where(s => s.Id == P.Id).FirstOrDefault();
                o.Category = P.Category;
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Created");

            }
            catch (Exception ex)
            {
                db.ProductCategories.Remove(P);
                return cm.RecordError(ex.InnerException.Message, "", "Test", "DatabaseMaster", "AddProductcategory", "Add");
            }

        }

        public List<ProductCategory> List(string srch)
        {
            if(srch!=null)
            return db.ProductCategories.Where(s => s.Category.Contains(srch)).ToList();
            else
                return db.ProductCategories.ToList();
        }
    }
}
