﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebNews.Data.Entities
{
    public class NewsInUser
    {
        public int NewsID { get; set; }

        public News News { get; set; }

        public int UserID { get; set; }

        public User User { get; set; }
    }
}
