using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNews.Data.Entities
{
    public class Comments
    {
        public int Id { get; set; }
        public string content { get; set; }
        public DateTime date_published { get; set; }

        public int article_id { get; set; }
        public int author_id { get; set; }

    }
}
