﻿using EntityFrameworkDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo
{
    public class Product:IEntity
    {
        public int ProductId { get; set; } //Primary Key
        public int CategoryId { get; set; } //Foreign Key
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
    }
}
