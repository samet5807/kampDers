﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Product
    {
          public    int Id { get; set; }    
        public string ProductName { get; set; }    
        public double UnitPrice { get; set; } 

        public int CatagoryId { get; set; }

        public  int UnitInStock { get; set; }
        

    
    }
}
