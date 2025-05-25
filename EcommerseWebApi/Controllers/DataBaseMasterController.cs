using EcommerseWebApi.Model.Implementation;
using EcommerseWebApi.Model.Table;
using Microsoft.AspNetCore.Mvc;

namespace EcommerseWebApi.Controllers
{
    public class DataBaseMasterController : Controller
    {
        public ApplicationDBContext db;

        public DataBaseMasterController(ApplicationDBContext _db)
        {
            db = _db;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public CommMessage_Modal ProductcategoryProcess(string Process,[FromBody] ProductCategory p)
        {
            IMP_ProductCategory pc = new IMP_ProductCategory(db);
            if (Process.Equals("Add"))
                return pc.ADD(p);
            if (Process.Equals("Edit"))
                return pc.Edit(p);
            if (Process.Equals("Delete"))
                return pc.Delete(p);

            return null;

        }
        [HttpGet]
        public List<ProductCategory> ProductCategoryList(string srch)
        {
            IMP_ProductCategory pc = new IMP_ProductCategory(db);
            return pc.List(srch);

        }
    }
}
