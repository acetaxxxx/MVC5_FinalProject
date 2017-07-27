using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Final_Project.Controllers
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
		public ActionResult Login()
		{
			
			return View();
		}
		[HttpPost]
		public ActionResult Login(string account,string password)
		{
			if (ModelState.IsValid)
			{
				ViewData["message"] = "登入成功";
			}
			return View();
		}

		public ActionResult verify(string account)
		{
			string[] errorList = new string[] { "skilltree" , "demo" , "twMVC" };

			bool IsValidate = true;
			foreach (string s in errorList)
			{
				if (account.Contains(s))
				{ IsValidate = false; }
			}
			 
			return Json(IsValidate , JsonRequestBehavior.AllowGet);

		}
	}
}