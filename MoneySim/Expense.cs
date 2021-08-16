using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySim
{
    class Expense
    {
        public string Name;
        public int Price;
        public int Occurence;

        public Expense(string name, int price, int occurence=0)
        {
            Name = name;
            Price = price;
            Occurence = occurence;
        }

        public void SaveToDatabase(Expense item)
        {
            //insert item into expense table
        }
    }
}
