using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace knapsack
{
    class Rucksack
    { 
        private int _max_weight;
        private List<Item> _items = null;
        private int _price;

        public Rucksack(int weight)
        {
            _max_weight = weight;
        }

        private int calcWeight(List<Item> items)
        {
            int totalWeght = 0;

            foreach(Item i in items)
            {
                totalWeght += i._weight;
            }
            return totalWeght;
        }
         private int calcPrice(List<Item> items)
        {
            int totalPrice = 0;

            foreach (Item i in items)
            {
                totalPrice += i._price;
            }

            return totalPrice;
        }

        private void CheckSet(List<Item> items)
        {
            if (_items == null)
            {
                if (calcWeight(items) <= _max_weight)
                {
                    _items = items;
                    _price = calcPrice(items);
                }
            }
            else
            {
                if (calcWeight(items) <= _price && calcPrice(items) > _price)
                {
                    _items = items;
                    _price = calcPrice(items);
                }
            }
        }

        public void permutation (List<Item> items)
        {
            if (items.Count > 0)
                CheckSet(items);
                    
            for (int i = 0; i < items.Count; i++)
            {
                List<Item> newSet = new List<Item>(items);
                newSet.RemoveAt(i);
                permutation(newSet);
            }
        }
        public List<Item> getRucksack()
        {
            return _items;
        }



    }
}
