using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySim
{
    class Program
    {
        static void Main(string[] args)
        {
            InitMenu();
        }
        public static void InitMenu()
        {
            Console.WriteLine("To add Expenses press 0,Track expense press 1, To simulate press 2: ");
            string choice = Console.ReadLine();
            if ("0".Equals(choice)) //kiadás felvétele
            {
                DatabaseHandler dbHandler = new DatabaseHandler();
                Expense expense = new Expense("Golden Virginia", 2500, 4);
                dbHandler.InsertItem(expense);
            }
            else if ("1".Equals(choice))   // Felvett költségek naptárhoz rendelése,hogy a gyakoriságot lehessen traackelni.
            {

            }
            else if ("2".Equals(choice))   // szimuláció
            {
                Simulator sim = new Simulator(5);
            }
        }
    }
}
