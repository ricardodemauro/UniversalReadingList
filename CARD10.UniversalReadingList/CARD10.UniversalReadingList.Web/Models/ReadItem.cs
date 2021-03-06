﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARD10.UniversalReadingList.Web.Models
{
    public class ReadItem
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public string Uri { get; set; }

        public int? CategoryId { get; set; }

        public Category Category { get; set; }
    }
}
