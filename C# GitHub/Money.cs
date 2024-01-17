using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace less
{
    /*Product - просят лише по працювати з цілим числом,центи не зачеплювати як я зрозумів.
    Щодо доп полів що ви казали, я б на свою думку зробив його одним double*/

    public class Money
    {
        protected int money = 0;
        protected double cent = 0;
        
        protected Money() { }
        public Money(int money, double cent) 
        {
            this.money = money;
            this.cent = cent;
        }

        public void PrintMoney()
        {
            Console.WriteLine($"{money}.{cent}");
        }
        public void SetNewSumm()
        {
            Console.Write("Sum: "); money = Convert.ToInt32(Console.ReadLine());
            Console.Write("Cent: "); cent = Convert.ToInt32(Console.ReadLine());
        }
    }

    public class Product : Money
    {
        private int reduceTheSum = 0;
        private int summ = 0;
        public Product() { }
        public Product(int money, double cent, int reduceTheSum) : base(money, cent)
        {
            this.reduceTheSum = reduceTheSum;
        }
        public void printProductSum()
        {
            base.PrintMoney();
            if (summ >= 0) Console.WriteLine($"New sum: {summ}.{cent}");
        }
        public new void SetNewSumm()
        {
            base.SetNewSumm();
            Console.Write("reduce The Sum: "); reduceTheSum = Convert.ToInt32(Console.ReadLine());
            if (reduceTheSum >= 0 && reduceTheSum <= money) summ = money - reduceTheSum;
        }
    }
}
