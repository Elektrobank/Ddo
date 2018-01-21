using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ddo.Data;
using Ddo.Models;
using NPoco;

namespace Ddo.Controllers
{
    public class ItemsController : Controller
    {
        DdoRepository Ddo = new DdoRepository();
        int userId = 1;
        public ActionResult Index()
        {
            ViewBag.Message = "DDO Items for users";

            var viewModel = new IndexViewModel();
            viewModel.ItemList = Ddo.GetItems(userId);

            return View(viewModel);
        }

        public ActionResult Update(int itemId, string newValue)
        {
            Items item = Ddo.db.SingleById<Items>(itemId);
            Items i2 = Ddo.db.Single<Items>("where Id = @0", itemId);
            item.ItemFullDesc = newValue;
            Ddo.db.Update(item);
            return RedirectToAction("Index");
        }

    }
}