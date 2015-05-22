using Newtonsoft.Json;
using ProductWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace ProductWebApi.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            string json;
            Product product;

            try
            {
                using (var client = new WebClient())
                {
                    //json = client.DownloadString("http://localhost:26307/api/Products?p=1");
                }
                //product = JsonConvert.DeserializeObject<Product>(json);
                //ViewBag.Json = json;
            }
            catch(Exception exc)
            {
            
            }

            return View();
        }
    }
}
