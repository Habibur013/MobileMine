﻿using eCommerce.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eCommerce.Repository
{
    public class CategoryRepository : Repository<Category>
    {
        public CategoryRepository(MobileMineContext context) : base(context)
        {

        }
    }
}