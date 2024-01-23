using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Parcels.Models;

namespace Parcels.Controllers
{
    public class ParcelsController : Controller
    {
        [HttpGet("/parcels")]
        public ActionResult Index()
        {
            List<Package> allPackages = Package.GetAll();
            return View(allPackages);
        }

        [HttpGet("/parcels/new")]
        public ActionResult SubmitParcel()
        {
            return View();
        }

        [HttpPost("/parcels")]
        public ActionResult Create(int height, int length, int width, int weight)
        {
            Package parcel = new(height, length, width, weight);
            return RedirectToAction("Index");
        }
    }
}