using SugarCube.Models;
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
        public User Author { get; set; }
        public string Text { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public int NodCount { get; set; }
        public int CommentCount
        {
            get
            {
                return Comments.GetCount();
            }
        }
        public IEnumerable<Comment> Comments { get; set; }
    }

}

public static class CommentExtensions
{
    public static int GetCount(this IEnumerable<Comment> comments)
    {
        return comments.Sum(x => x.Comments.GetCount()) + comments.Count();
    }
}