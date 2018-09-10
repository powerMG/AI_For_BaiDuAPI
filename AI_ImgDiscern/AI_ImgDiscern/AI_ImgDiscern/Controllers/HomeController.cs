using AI_ImgDiscern.Models.Baidu;
using AI_ImgDiscern.Models.Baidu.Aip.BodyAnalysis;
using Baidu.Aip.BodyAnalysis;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AI_ImgDiscern.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var result = imgServer.BodyNumDemp();
            var model = JsonConvert.DeserializeObject<ResultModel>(result.ToString());
            ViewBag.personNum = model.person_num;
            ViewBag.personImg = model.image;
            ViewBag.personId = model.log_id;
            return View();
        }
    }
}