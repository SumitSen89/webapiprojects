using EcommerseWebApi.Model.Table;

namespace EcommerseWebApi.Model.Implementation
{
    public class IMP_Specification
    {
        ApplicationDBContext db;
        public IMP_Specification(ApplicationDBContext _db)
        {
            db = _db;
        }
        public CommMessage_Modal Add(Specification p)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                db.Specifications.Add(p);
                db.SaveChanges();
                return cm.GenerateMessage("Specification Type Created");
            }
            catch (Exception ex)
            {
                db.Specifications.Remove(p);
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "AddProductCategory", "Add");
            }
        }

        public CommMessage_Modal Edit(Specification p)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                Specification o = db.Specifications.Where(s => s.Id == p.Id).FirstOrDefault();
                o.Label = p.Label;
                o.Value = p.Value;
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Modified");
            }
            catch (Exception ex)
            {
                db.Specifications.Remove(p);
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "AddProductCategory", "Add");
            }
        }
        public CommMessage_Modal Delete(Specification p)
        {
            CommMessage cm = new CommMessage(db);
            try
            {
                Specification o = db.Specifications.Where(s => s.Id == p.Id).FirstOrDefault();
                db.Specifications.Remove(o);
                db.SaveChanges();
                return cm.GenerateMessage("Product Category Removed");
            }
            catch (Exception ex)
            {
                return cm.RecordError(ex.InnerException.Message, ex.InnerException.ToString(), "Test", "DatabaseMaster", "AddProductCategory", "Delete");
            }
        }
        public List<Specification> List(string srch)
        {
            if (srch != null)
                return db.Specifications.Where(s => s.Label.Contains(srch)).ToList();
            else
                return db.Specifications.ToList();
        }
    }
}
