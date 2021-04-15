 using System;
 
 public abstract class BankAccount
    {
        public string AcctNbr { get; set; }
        public string Name { get; set; }
        public double Balance { get; set; }
        public DateTime DateCreated { get; set; }

        public BankAccount()
        {
            Balance = 1000;
        }

         public BankAccount(double balance)
        {
            Balance = balance;
        }

        public void Deposit(double amount)
        {
          Deposit = 300
          Console.WriteLine("Current Balance is " + Deposit + Balance);
        }

        public void Withdraw(double amount)
        {
          Withdraw = 600
          if ( Balance > 2000)
          {
            
          }
          else 
          {
           Console.WriteLine"Error";
          }
           Console.WriteLine("Current Balance is "+ balance);
          } 
          Public override Withdraw
          {

          }

        
        public abstract void CalculateInterest() { }

    }