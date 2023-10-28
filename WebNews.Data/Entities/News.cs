using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebNews.Data.Enums;

namespace WebNews.Data.Entities
{
    public class News
    {
        public int ID { get; set; }
        public String Title { get; set; }
        public String Describe { get; set; }
        public String Category { get; set; }
        public DateTime DateCreated { get; set; }
        public Status Status { get; set; }
        public int Image { get; set; }

        public List<NewsInUser> NewsInUsers { get; set; }
    }
}
