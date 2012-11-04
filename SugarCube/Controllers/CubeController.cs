﻿using System;
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

        private void Initialize(out List<JournalEntry> cubes, out  SelectListItem[] tags, out  SelectListItem[] permissions)
        {
            cubes = new List<JournalEntry>(){
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

            permissions = new SelectListItem[] {
                new SelectListItem{ Text = "friends & strangers", Value = "5"},
                new SelectListItem{ Text = "maybe friends", Value = "4"},
                new SelectListItem{ Text = "just friends", Value = "3"},
                new SelectListItem{ Text = "dear best friends", Value = "2" },
                new SelectListItem{ Text = "my eyes only", Value = "1" },
                new SelectListItem{ Text = "friends & strangers", Value = "5"},
                new SelectListItem{ Text = "maybe friends", Value = "4"},
                new SelectListItem{ Text = "just friends", Value = "3"},
                new SelectListItem{ Text = "dear best friends", Value = "2" },
                new SelectListItem{ Text = "my eyes only", Value = "1" }
            };


            Random rand = new Random();
            var tagsList = new List<SelectListItem>();
            for(int i = 1; i <= 30; i++)
            {
                switch (rand.Next(1, 3))
                {
                    case 1:
                        tagsList.Add(new SelectListItem { Text = "cat " + i, Value = i.ToString() });
                        break;
                    case 2:
                        tagsList.Add(new SelectListItem { Text = "calvin & hobbes " + i, Value = i.ToString() });
                        break;
                    case 3:
                        tagsList.Add(new SelectListItem { Text = "elephant " + i, Value = i.ToString() });
                        break;
                }
            };

            tags = tagsList.ToArray();
        }

        public ActionResult Index()
        {
            List<JournalEntry> cubes;
            SelectListItem[] tags;
            SelectListItem[] permissions;
            Initialize(out cubes, out tags, out permissions);
            return View(new CubeViewModel() { JournalEntries = cubes, Tags = tags, Permissions = permissions });
        }

        public ActionResult GetCubes()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        public ActionResult CreateJournal(FormCollection form)
        {
            List<JournalEntry> cubes;
            SelectListItem[] tags;
            SelectListItem[] permissions;
            Initialize(out cubes, out tags, out permissions);
            return View("Index", new CubeViewModel() { JournalEntries = cubes, Tags = tags, Permissions = permissions });
        }

    }
}
