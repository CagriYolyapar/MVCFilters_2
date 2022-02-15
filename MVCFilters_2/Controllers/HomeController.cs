using MVCFilters_2.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFilters_2.Controllers
{
    [ActFilter]
    [ResFilter]
    public class HomeController : Controller
    {


        #region Filters

        //Filter'ların görevi kontrol ettikleri Action'lar veya Controller'lar calısmadan önce veya calıstıktan sonra devreye girip iclerinde yazdıgınız görevleri yapmaktır...

        //Action Filter => Kullanıcı bir Action'a girmeden önce veya Action'i calıstırdıktan sonraki durumlarda devreye giren bir yapıdır...

        //Result Filter => Kullanıcı bir View'a giriş yapmadan önce veya View render edildikten sonra devreye giren metotları barındıran bir yapıdır...

        //Authentication Filter => Tamamen yetkilendirme ile ilgilenen bir filter yapısıdır...

        //Exception Filter => Bir Action'da hata olustugunda calısan bir filter yapısıdır...

        //Bir Filter belirleyebilmek icin yarattıgınız sınıfın bir attribute olarak yazılabilecek bir sınıfa dönüsmesi gerekir...




        #endregion






        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}