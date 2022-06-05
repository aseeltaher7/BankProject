using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
   abstract class Account
    {
        public readonly string name;
        public readonly string ID;
        public readonly DOB DOB;
        public readonly string User;
        public double balance;
        protected string type;
        public double ammount;
        public abstract bool deposit(double amount);

        public abstract bool withdraw(double amount);
        
        public double getBalance()
        {
            return balance;
        }
        public string getAccType()
        {
            string actype;
            actype = Convert.ToString(Console.ReadLine());
            return actype;
        }
        public void printAccount()
        {
           
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Date of Birth :" + DOB);
            Console.WriteLine("User : " +User);
            Console.WriteLine("Balance :" + balance);
        }
        public Account()
        {

        }
        public Account(string name, DOB DOB, string User, double balance)
        {
            this.name = name;
            this.DOB = DOB;
            this. User = User;
     
            this.balance = balance;
        }
    }
}
