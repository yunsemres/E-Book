﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EBook.UI.Areas.Admin.Models.DTO
{
    public class SubCategoryDTO
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid CategoryID { get; set; }
    }
}