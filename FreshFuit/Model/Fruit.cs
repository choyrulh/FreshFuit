using System;
using System.Collections.Generic;
using System.Text;

namespace FreshFuit.Model
{
    class Fruit
    {
        public string name { get; set; }

        public Fruit(string name)
        {
            this.name = name;
        }
        public string getName()
        {
            return this.name;
        }
    }
}
