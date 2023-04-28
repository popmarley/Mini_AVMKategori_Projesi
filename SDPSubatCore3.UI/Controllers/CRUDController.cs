using Microsoft.AspNetCore.Mvc;
using SDPSubatCore3.UI.Models.Core.Context;
using SDPSubatCore3.UI.Models.Core.Entities;
using System.Linq;

namespace SDPSubatCore3.UI.Controllers
{
	public class CRUDController : Controller
	{
		readonly MyDBContext _context;
		public CRUDController(MyDBContext context)
		{
			_context = context;
		} 

		public IActionResult Index()
		{
            //_context.Categories.Add(new Models.Core.Entities.Category()
            //{
            //    CategoryName = "sebze"
            //});
            //_context.SaveChanges();

            //_context.Products.Add(new Models.Core.Entities.Product()
            //{
            //    CategoryID = 1,
            //    ProductName = "salatalık",
            //    UnitPrice = 10
            //});
            //_context.SaveChanges();




            var listem = _context.Products.ToList();
			return View(listem);
		}

        public IActionResult Duzenle(int ID)
        {
            Product duzenlenmesiIstenenData = _context.Products.SingleOrDefault(a => a.ProductID == ID);

            return View(duzenlenmesiIstenenData);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult VeriyiDuzenle(Product model)
        {
            //eski yol.
            //var data = _context.Products.SingleOrDefault(a => a.ProductID == model.ProductID);
            //data.ProductName = model.ProductName;
            //data.CategoryID = model.CategoryID;
            //data.UnitPrice = model.UnitPrice;
            //int hede = _context.SaveChanges();

            ////2. yol
            //_context.Products.Attach(model);
            //_context.Entry(model).State = Microsoft.EntityFrameworkCore.EntityState.Modified;

            //yeni yol
            _context.Products.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Sil(int ID)
        {
            _context.Products.Remove(new Product { ProductID = ID });
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

		public IActionResult Detay(int ID)
		{
			// ID'ye göre ilgili ürünü veritabanından çekiyoruz.
			Product urun = _context.Products.SingleOrDefault(a => a.ProductID == ID);
			// Ürünü Detay sayfasına gönderiyoruz.
			return View(urun);
		}


		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Ekle(Product model)
		{
			_context.Products.Add(model);
			_context.SaveChanges();

			return RedirectToAction("Index", "CRUD");
		}


	}
}
