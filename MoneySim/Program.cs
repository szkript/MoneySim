using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            //string choice = Console.ReadLine();
            string choice = "2";
            if ("0".Equals(choice)) //kiadás felvétele
            {
                DatabaseHandler dbHandler = new DatabaseHandler();
                while (true)
                {
                    Console.WriteLine("Add expense: Name,Price\n");  //occurence will be calculated on tracking
                    string input = Console.ReadLine();
                    if ("".Equals(input) || !input.Contains(','))
                    {
                        break;
                    }
                    string[] prms = input.Split(',');
                    Expense expense = new Expense(prms[0], int.Parse(prms[1]));
                    dbHandler.InsertItem(expense);
                }
            }
            else if ("1".Equals(choice))   // Felvett költségek naptárhoz rendelése,hogy a gyakoriságot lehessen traackelni.
            {

            }
            else if ("2".Equals(choice))   // szimuláció
            {
                Console.WriteLine("Days of simulation:");
                string input = Console.ReadLine();
                try
                {
                    int days = int.Parse(input);
                    Simulator sim = new Simulator(days);
                }
                catch (Exception e)
                {
                    Debug.WriteLine(e.Message);
                }
            }
        }
    }
}
