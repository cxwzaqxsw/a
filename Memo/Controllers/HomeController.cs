using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Memo.Controllers
{
    public class HomeController : Controller
    {
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

        public ActionResult Welcome()
        {
            DateTime.Now.ToString();
            return View();
        }
       
            /// <summary>
            /// 新闻列表
            /// </summary>
            /// <returns></returns>
            
            
            public ActionResult List(int page=10)

        {
            string[] data = new string[] { "超逗动物表情包 不信你不笑", "摄影师镜头下的极寒美景" };
            ViewBag.Page = page;
            ViewBag.data = data;
            return View();
        }
    }
}