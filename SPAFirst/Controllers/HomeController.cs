using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SPAFirst.Controllers
{
	public partial class HomeController : Controller
	{
		public HomeController()
		{
			//System.Globalization.CultureInfo oCultureInfo =
			//	new System.Globalization.CultureInfo("en-US");

			System.Globalization.CultureInfo oCultureInfo =
				new System.Globalization.CultureInfo("fa-IR");

			System.Threading.Thread.CurrentThread.CurrentCulture = oCultureInfo;
			System.Threading.Thread.CurrentThread.CurrentUICulture = oCultureInfo;

		}
		// GET: Home
		public virtual ActionResult Index()
		{
			return View();
		}

		public virtual ActionResult About()
		{
			ViewBag.Message = "About this Application";
			return View();
		}


	}
}