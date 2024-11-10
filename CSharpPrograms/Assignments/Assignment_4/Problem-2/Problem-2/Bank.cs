using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2
{
    internal class InsuffientBalanceException : ApplicationException
    {
        public InsuffientBalanceException(string msg) : base(msg)
        {

        }
        class Account
        {
            public int accno, amount;
            public float bal;
            public string customername;
            public string acctype,trasactiontype;
            public Account(int accno, int amount, float bal, string customername, string acctype, string trasactiontype)
            {
                this.accno = accno;
                this.amount = amount;
                this.bal = bal;
                this.customername = customername;
                this.acctype = acctype;
                this.trasactiontype = trasactiontype;
            }
            public void deposit(int n)
            {
                if (n > 0)
                {
                    bal+=n;
                    Console.WriteLine("Ammount is successfully credited  ");

                }
                else
                {
                    throw (new InsuffientBalanceException("Enter amount greater than Zero"));
                }
            }


            public void withhdraw(int n)
            {
                if(n>0 &&  n<bal)
                {
                    bal -= n;
                    Console.WriteLine("Amount is succcessfully debited");
                }
                else if (n>bal)
                {
                    throw (new InsuffientBalanceException("Insuffient Balance"));
                }
            }

            public void balance(string trasaction_type, int amount)
            {
                if (trasaction_type =="d")
                {
                    deposit(amount);
                }
                else
                {
                    withhdraw(amount);
                }
            }

            public void showdata()
            {
                Console.WriteLine("Acccount number is {0}", accno);
                Console.WriteLine("Customer name is {0}", customername);
                Console.WriteLine("AccountType is {0}", acctype);
                Console.WriteLine("Transaction Type is {0}", trasactiontype);
                Console.WriteLine("Remaining Balance is {0}", bal);
            }
        }
        class Program
        {
            static void main(string[] args)
            {
                Console.WriteLine("Enter the account number");
                int accno = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the customer  name");
                string customername = Console.ReadLine();
                Console.WriteLine("Enter the account type (current/savings)");
                string acctype = Console.ReadLine();
                Console.WriteLine("Enter the transaction type(deposit/withdrawl)");
                string trasactiontype = Console.ReadLine();
                Console.WriteLine("Enter the amount");
                int amount = Convert.ToInt32(Console.ReadLine());

                Account acc = new Account(accno, customername, acctype, trasactiontype, amount);

                acc.showdata();
                while (true)
                {
                    Console.WriteLine("Enter transaction type(Deposit/Withdrawl)");
                    string transtype= Console.ReadLine();
                    if (transtype == "p")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Enter amount");
                        int amt = Convert.ToInt32(Console.ReadLine());
                    }
                    try
                    {
                        acc.balance(transtype, amount);
                    }
                    catch (InsuffientBalanceException ex) 
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                acc.showdata();


            }
          Console.ReadLine();
           

        }
       
    }
}
