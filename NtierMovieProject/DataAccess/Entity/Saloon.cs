﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Saloon:BaseEntity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Capacity { get; set; }
        public List<Theater> Theaters { get; set; }
    }
}
