using _13309zadanie1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _13309zadanie1.Controllers
{
    public class PlytyController : Controller
    {
        public static List<Plyty> list = new List<Plyty>() { };
        public IActionResult Index()
        {
            return View();
        }
        public ActionResult Add()
        {
            return View("Add");
        }
        [HttpPost]
        public ActionResult Add(Plyty plyty)
        {
            int index = 0;
            if (ModelState.IsValid)
            {
                plyty.Id = index++;
                list.Add(plyty);
                return View("ConfirmAdd", plyty);

            }
            else
            {
                return View("Add");
            }
        }
        public ActionResult FindAll()
        {
            return View("List", list);
        }
    }
}
