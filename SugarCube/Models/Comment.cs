using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SugarCube.Models
{
    public class Comment
    {
        public string Text { get; set; }
        public User Author { get; set; }
        public DateTime Timestamp { get; set; }
        public IEnumerable<Comment> Comments { get; set; }

        public Comment()
        {
            Comments = new Comment[] { };
        
        }
    }
}