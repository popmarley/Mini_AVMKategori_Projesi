using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System.Text.Json;
using System;
using SDPSubatCore3.UI.Models.VM;
using SDPSubatCore3.UI.Models.Common;

namespace SDPSubatCore3.UI.Controllers
{
    public class MyData
    {
        public string username { get; set; }
        public string pass { get; set; }
    }


    public class DefaultController : Controller
    {
        IConfiguration _configuraiton;
        public DefaultController(IConfiguration configuraiton)
        {
            _configuraiton = configuraiton;
        }
        public IActionResult Index()
        {
            var deger01 = _configuraiton.GetConnectionString("MyConn");
            var deger02 = _configuraiton["ConnectionStrings:MyConn"];
            var deger03 = _configuraiton["MyConn2"];
            var deger04 = _configuraiton["MyData:pass"];

            var deger05 = _configuraiton.GetSection("MyData").Get(typeof(MyData));

            MyData conf = (MyData)deger05;

            TempData.Add("hede", JsonSerializer.Serialize(conf));//çekerken deserilize etmek lazım

            var temptenGelenData = JsonSerializer.Deserialize<MyData>(TempData["hede"].ToString());

            Personel p = new Personel()
            {
                Ad = "hüseyin",
                Soyad = "deneme"
            };

           HttpContext.Session.SetString("bidi", JsonSerializer.Serialize(p));
            var userJson = HttpContext.Session.GetString("bidi");

           var myUser = JsonSerializer.Deserialize<Personel>(userJson);

            HttpContext.Session.MySet("hüseyin", p);
            var extensionValue = HttpContext.Session.MyGet<Personel>("hüseyin");



            // return View((conf,p));
            return View(Tuple.Create<MyData, Personel>(conf, p));
        }
    }
}
