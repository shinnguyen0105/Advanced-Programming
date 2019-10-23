using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMSequence
{
    class Program
    {
        class Customer
        {

            public string customerName;
            public Customer()
            {

            }
            public void InsertCard(Card card, ATM atm)
            {
                atm.RequestPIN();
                int PIN = EnterPIN();

                if (!atm.VerifyPIN(PIN, card))
                {
                    Console.WriteLine("PIN Not Accepted ...");
                }
                else
                {
                    Console.WriteLine("PIN Accepted ...");
                    Console.WriteLine("Please choose options");
                    Console.WriteLine("1. Withdraw");
                    Console.WriteLine("2. Exit");
                }

            }

            public void SelectOption(int option)
            {
                switch (option)
                {
                    case 1:

                        break;
                    case 2:
                        break;
                }
            }

            int EnterPIN()
            {
                int PIN = Convert.ToInt32(Console.ReadLine());
                return PIN;
            }

            public void TakeCash(ATM atm, Account account)
            {
                atm.AtmGetSetBalance = atm.AtmGetSetBalance - account.WithdrawAmount();
            }

            public void Terminate()
            {

            }


        }

        class ATM
        {

            public int ATMID;
            double ATMBalance;
            public ATM(int atmID, double atmBalance)
            {
                ATMID = atmID;
                ATMBalance = atmBalance;
            }

            public double AtmGetSetBalance
            {
                get { return ATMBalance; }
                set { ATMBalance = value; }
            }
            public void RequestPIN()
            {
                Console.Write("Please Enter Your PIN: ");

            }

            public bool VerifyPIN(int pin, Card card)
            {


                return pin == card.GetAccount().GetPIN();
            }

            public void RequestAmount()
            {
                Console.Write("Please input amount to withdraw: ");
            }

            public void DispenseCash()
            {
                Console.WriteLine("Please take your money");
            }

            public void RequestTakeCash()
            {
                Console.WriteLine("Please remember take your cash");
            }

            public void RequestContinuation()
            {
                Console.WriteLine("Do you do another transaction?");
            }

            public void PrintReceipt(Customer customer, Account account, ATMTransaction transaction)
            {
                Console.Write($"Atm ID: {ATMID}");
                Console.Write($"\nTransaction ID: {transaction.transactionID}");
                Console.Write($"\nCustomer Name: {customer.customerName}");
                Console.Write($"\nYour Balance: {account.Balance}");
                Console.WriteLine("\n Thanks for using our service!");
            }
        }

        class Account
        {
            int PIN;
            double BALANCE;
            public Account(int pin, double Balance)
            {
                PIN = pin;
                BALANCE = Balance;
            }
            public int GetPIN()
            {
                return PIN;
            }

            public double Balance
            {
                get { return BALANCE; }
                set { value = BALANCE; }
            }

            public bool TransactionSuccessful()
            {
                Balance = Balance - WithdrawAmount();
                Console.WriteLine(" Transaction Successful!");
                return true;
            }


            public double WithdrawAmount()
            {
                double Amount = Convert.ToInt32(Console.ReadLine());
                return Amount;
            }
        }

        class CheckingAccount
        {
            public bool CheckWithdraw(Account account)
            {
                if (account.Balance < account.WithdrawAmount(0))
                    return false;
                else return true;
            }
        }

        class Card
        {

            Account Account;
            public Card()
            {
                Account = new Account(1234, 10000);
            }


            public Account GetAccount()
            {
                return Account;
            }
        }

        class ATMTransaction
        {
            public int transactionID;

        }

        static void Main(string[] args)
        {
            Card myCard = new Card();
            ATM myATM = new ATM(1, 100000);
            Customer myCustomer = new Customer();

            myCustomer.InsertCard(myCard, myATM);

            Console.ReadKey();
        }
    }
}