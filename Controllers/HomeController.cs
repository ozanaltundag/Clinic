﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Web.Controllers
{
	public class HomeController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult About()
		{
			ViewBag.Message = "Op. Dr Hakan Demirel";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Estetik Clinic";

			return View();
		}
	}
}