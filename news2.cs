using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace news2.Models
{
    public class News
    {
        public int Id { get; set; }
        public string Head { get; set; }
        public string Content { get; set; }
        public string Tags { get; set; }
    }
    public class NewsContext : DbContext
    {
        public NewsContext()
            : base ("DefaultConnection")
        { }
        public DbSet<News> AllNews { get; set; }
    }
}
