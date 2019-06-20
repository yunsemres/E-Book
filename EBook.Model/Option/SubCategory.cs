﻿using EBook.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EBook.Model.Option
{
    public class SubCategory:CoreEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }

        public virtual List<Article> Articles { get; set; }
    }
}
