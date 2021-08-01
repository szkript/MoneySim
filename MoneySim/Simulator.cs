using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySim
{
    class Simulator
    {
        private const int MonthlyIncome = 250000;
        private int DaysToSimulate;
        private List<Expense> Expenses;
        public Simulator(int numberOfDays)
        {
            DatabaseHandler dh = new DatabaseHandler();
            Expenses = dh.LoadFromDatabase();
            DaysToSimulate = numberOfDays;
        }        
        public void Simulate()
        {
            for (int day = 0; day < DaysToSimulate; day++)
            {

            }
        }
    }
}
