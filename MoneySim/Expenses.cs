using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoneySim
{
    class Expenses
    {
        //when created a new instance of this it should preload all kind of expenses into different lists with different parameters
        //ezeket a class inicializálásánál kell betölteni a már adatbázisban szereplő adatokkal
        public List<Expense> dailyExpense;//napi kiadásokat összegzi
        public List<Expense> periodicalExpense;//bizonyos időnkéntni fix kiadásokat mint polk dohány
        public List<Expense> monthlyExpense;//havi fix 1x kiadások mint pl hiteltörlesztés
        public List<Expense> creditExpense;//hitel törlesztések nyoomon követése
        public Expenses()
        {
            InitExpenses();
        }

        private void InitExpenses()
        {
            DatabaseHandler databaseHandler = new DatabaseHandler();
            dailyExpense = databaseHandler.GetDailyExpenses();
        }
    }
}
