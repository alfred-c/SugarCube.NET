using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SugarCube.Models
{
    public class CubeViewModel
    {
        public List<JournalEntry> JournalEntries { get; set; }

        public SelectListItem[] Tags { get; set; }

        public SelectListItem[] Permissions { get; set; }
    }
}