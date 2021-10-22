using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Item
    {
        public string _name { get; set; }
        public int _weight { get; set; }
        public int _price { get; set; }

        public Item (string name, int weight, int price)
        {
            _name = name;
            _weight = weight;
            _price = price; 

        }
    }
}
