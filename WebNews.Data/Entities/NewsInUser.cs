using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNews.Data.Entities
{
    public class NewsInUser
    {
        public int author_id { get; set; }

        public News News { get; set; }

        public int category_id { get; set; }

        public User User { get; set; }
    }
}
