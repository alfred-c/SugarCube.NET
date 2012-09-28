using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SugarCube.Models;

namespace SugarCube.Controllers
{
    public class CubeController : Controller
    {
        //
        // GET: /Cube/

        public ActionResult Index()
        {
            List<JournalEntry> cubes = new List<JournalEntry>(){
                new JournalEntry{ Title = "Hello World 1", Date=DateTime.Today, Text = "This is a short message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 2", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="other" },
                new JournalEntry{ Title = "Hello World 3", Date=DateTime.Today, Text = "This is a message with an image.", Image = "~/Content/Images/logo.png", Type="journal"},
                new JournalEntry{ Title = "Hello World 4", Date=DateTime.Today, Image = "~/Content/Images/logo.png", Type="journal" },
                new JournalEntry{ Title = "Hello World 5", Date=DateTime.Today, Text = "This is a short message.", Type="other" },
                new JournalEntry{ Title = "Hello World 6", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 7", Date=DateTime.Today, Image = "~/Content/Images/logo.png", Type="journal" },
                new JournalEntry{ Title = "Hello World 8", Date=DateTime.Today, Text = "This is a short message.", Type="other" },
                new JournalEntry{ Title = "Hello World 9", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 10", Date=DateTime.Today, Text = "This is a short message.", Type="journal" },
                new JournalEntry{ Title = "Hello World 11", Date=DateTime.Today, Text = "This is a somewhat longer message.", Type="other" },
                new JournalEntry{ Title = "Hello World 12", Date=DateTime.Today, Text = "This is a message with an image.", Image = "~/Content/Images/logo.png", Type="journal"}

            };
            return View(new CubeViewModel() { JournalEntries = cubes });
        }

        public ActionResult GetCubes()
        {
            return View();
        }

    }
}
