﻿using EntityFrameworkDemo.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFrameworkDemo.Entities
{
    public class Personel:IEntity
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
    }
}
