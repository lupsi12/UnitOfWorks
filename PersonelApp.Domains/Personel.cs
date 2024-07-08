﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonelApp.Domains
{
    public class Personel:BaseEntity
    {
        public Personel()
        {
            personels = new List<Personel>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<Personel> personels { get; set; }
    }
}
