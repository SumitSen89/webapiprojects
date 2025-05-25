using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Implementation
{
    public class IMP_SpecificationType
    {
        ApplicationDBContext db;
        public IMP_SpecificationType(ApplicationDBContext _db)
        {
            db = _db;
        }

        public CommMessage_Modal Add(SpecificationType p)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                db.SpecificationTypes.Add(p);
                db.SaveChanges();
                return cm.GenerateMessage("Specification Type Created");
            }
            catch (Exception ex)
            {
                db.SpecificationTypes.Remove(p);
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "AddProductCategory", "Add");
            }
        }

        public CommMessage_Modal Edit(SpecificationType p)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                SpecificationType o = db.SpecificationTypes.Where(s => s.Id == p.Id).FirstOrDefault();
                o.SpecType = p.SpecType;
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Modified");
            }
            catch (Exception ex)
            {
                db.SpecificationTypes.Remove(p);
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "AddProductCategory", "Add");
            }
        }
        public CommMessage_Modal Delete(SpecificationType p)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                SpecificationType o = db.SpecificationTypes.Where(s => s.Id == p.Id).FirstOrDefault();
                db.SpecificationTypes.Remove(o);
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Removed");
            }
            catch (Exception ex)
            {
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "AddProductCategory", "Delete");
            }
        }
        public List<SpecificationType> List(string srch)
        {
            if (srch != null)
                return db.SpecificationTypes.Where(s => s.SpecType.Contains(srch)).ToList();
            else
                return db.SpecificationTypes.ToList();
        }
    }
}

