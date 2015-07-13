using SwiftyNames.V1._0.Models;
using SwiftyNames.V1._0.Persistants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace SwiftyNames.V1._0.Controllers
{
    [Authorize]
    public class NamesCatalogController : Controller
    {
        SwiftyNamesEntities context = new SwiftyNamesEntities();
        private Logics logic;
        // GET: NamesCatelog
        public ActionResult CatalogView()
        {
            return View();
        }
        private void BindCombo(NewsPaperModel model, IList<NewsPapersPrice> AvailableNewsPaper)
        {
            List<NewsPapersPrice> importname = new List<NewsPapersPrice>();
            model.NewsPapers = new MultiSelectList(AvailableNewsPaper, "Id", "NewsPaper","Price", importname.Select(x => x.Id));

        }
        [HttpGet]
        public ActionResult AvailableNewsPaper()
        {
             NewsPaperModel model = new NewsPaperModel();
             List<NewsPapersPrice> newspapers = new List<NewsPapersPrice>();
             newspapers = context.NewsPapersPrices.ToList();
             model.PriceList = new MultiSelectList(newspapers, "Id","Price",newspapers.Select(x => x.Id));
             model.NewsPapers = new MultiSelectList(newspapers, "Price", "NewsPaper", newspapers.Select(x => x.Price));
             ViewBag.delievery = "Do you want it delivered to your address";
             return View(model);
        }

        [HttpPost]
        public ActionResult AvailableNewsPaper(NewsPaperModel model)
        {
            
            Delivery deliver = new Delivery();
            if(!string.IsNullOrEmpty(model.Address) && !string.IsNullOrEmpty(model.phoneNumber))
            {
                deliver.Address = model.Address;
                deliver.PhoneNumber = model.phoneNumber;
                deliver.DateOrdered = DateTime.Now;
                context.Deliveries.Add(deliver);
                context.SaveChanges();
                TempData["success"] = "Your NewsPaper will be delivered to the given address in three days you can now proceed to payment";
            }

            List<NewsPapersPrice> newspapers = new List<NewsPapersPrice>();
            newspapers = context.NewsPapersPrices.ToList();
            model.PriceList = new MultiSelectList(newspapers, "Id", "Price", newspapers.Select(x => x.Id));
            model.NewsPapers = new MultiSelectList(newspapers, "Price", "NewsPaper", newspapers.Select(x => x.Price));
            ViewBag.delievery = "Do you want it delivered to your address";
            model.phoneNumber = string.Empty;
            model.Address = string.Empty;

            return View(model);
        }



        public ActionResult ChangeOfNamey()
        {
            return View();
        }
        public ActionResult ChangeOfNameForm()
        {
            return View();
        }
    }
}