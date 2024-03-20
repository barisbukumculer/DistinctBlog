using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DistinctBlog.Models.Entity;
using DistinctBlog.Models.Class;

namespace DistinctBlog.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        DistinctMvcDbEntities1 db=new DistinctMvcDbEntities1();
        public ActionResult Index()
        {
            Class1 cs = new Class1();
            cs.Deger1 = db.TBLHAKKINDA.ToList();
            cs.Deger2=db.TBLILETISIM.ToList();
            return View(cs);
        }
    }
}