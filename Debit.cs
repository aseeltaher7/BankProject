using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Debit : Account
    {
        public double maxBalance=1000000 ;
        private double dailyTransLimit = 1000000;

        public Debit() : base()
        {

        }

        public Debit(string name, DOB DOB, string User, double balance) : base(name, DOB, User, balance)
        {

        }



        public override bool deposit(double amount)
        {
            this.ammount = amount;
           if (amount > maxBalance)
            {
                Console.WriteLine("You can not deposit more than 1000000!");
                return false;
            }
            else
            {
               
                this.balance = balance + ammount;
                Console.WriteLine("You account balance has been deposited.Balance is: "+balance);
                return true;
            }
        }

        public override bool withdraw(double amount)
        {
            this.ammount = amount;
            
            if (amount > dailyTransLimit)
            {
                Console.WriteLine("You can not withdraw more than 100000.");
                return false;

            }
            else if(amount>maxBalance)
            {
                Console.WriteLine("You can not withdraw that ammount of money!");
                return false;
            }
            else
            {
                this.balance = balance - ammount;
                Console.WriteLine(" Your account balance has been withdrawed \n\n your Balance is: " + balance);
                return true;
            }
        }
    }
}
