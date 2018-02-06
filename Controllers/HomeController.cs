using System.Diagnostics.Contracts;
using Microsoft.AspNetCore.Mvc;
using Parcel.Models;

namespace Parcel.Controllers
{
    public class HomeController : Controller

  {
        [Route("/")]
        public ActionResult Index()
        {
            return View();
        }

        [Route("/Results")]
        public ActionResult Results()
        {
          ParcelVariable myParcelVariable = new ParcelVariable();
          myParcelVariable.SetWidth(Request.Query["width"]);
          myParcelVariable.SetLength(Request.Query["length"]);
          myParcelVariable.SetHeight(Request.Query["height"]);
          myParcelVariable.SetWeight(Request.Query["weight"]);
          return View(myParcelVariable);
        }

    }
  }
