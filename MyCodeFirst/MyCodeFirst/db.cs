﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyCodeFirst
{
    public class db : DbContext
    {
        public db() : base("name=constr1")
        {
        }
        public DbSet<human> humans { set; get; }

    }
        
}
