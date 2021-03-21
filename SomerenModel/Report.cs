﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenModel
{
    public class Report
    {
        
        public int Sales { get; set; } // the number of drinks
        public int Turnover { get; set; } // [sales * price of those drinks
        public int Customers { get; set; } // the date when the order was placed
    }
}
