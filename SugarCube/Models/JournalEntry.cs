using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SugarCube.Models
{
    public class JournalEntry
    {
        public DateTime Date { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
    }
}