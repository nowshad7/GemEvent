using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GemEvent.Models;
using GemDB.DBFunctions;

namespace EventPlanner_.Controllers
{
	
	public class HomeController : Controller
	{
		Client client = null;

		public HomeController()
		{
			client = new Client();

		}
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "About page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "contact page.";

			return View();
		}

		public ActionResult Service()
		{
			ViewBag.Message = "service page.";

			return View();
		}
		public ActionResult ClientRegister()
		{
			ViewBag.Message = "Register page.";

			return View();
		}

		[HttpPost]

		public ActionResult ClientRegister(ClientModel model)
		{
			if(ModelState.IsValid)
			{
				int ID = client.Register(model);
				if (ID > 0)
				{
					ModelState.Clear();
					ViewBag.Issuccess = "Successfully Registered!!";
				}
				else ViewBag.Issuccess = "Fail!!";
			}

			return View();
		}

	}
}