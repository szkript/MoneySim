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
        //todo: cserélni Expenses classra,majd az betölt minden szart
        private Expenses expenses;
        public Simulator(int numberOfDays)
        {
            expenses = new Expenses();
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
