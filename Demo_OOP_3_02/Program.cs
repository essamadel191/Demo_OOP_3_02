namespace Demo_OOP_3_02
{
    using System;
    public class Program
    {
        private int _age;
        static void Main(string[] args)
        {
            #region Encapsulation Using Getter and Setter Methods
            //BankAccount Acc01 = new BankAccount();
            //Acc01.SetBalance(-50); // invalid balance
            //Console.WriteLine($"Balance: {Acc01.GetBalance()}");

            //BankAccount Acc02 = new BankAccount();
            //Acc02.SetBalance(-50); // valid balance
            //Console.WriteLine($"Balance: {Acc02.GetBalance()}");
            #endregion

            #region Encapsulation Using Properties

            //BankAccount Acc03 = new BankAccount();
            //Acc03._name = "John Doe";
            //Console.WriteLine($"Name: {Acc03._name}");

            #endregion

            #region Property Types

            #region Read/Write Property
            //BankAccount account = new BankAccount();
            //account.AccountNumber = 123; // set
            //Console.WriteLine($"Account Number: {account.AccountNumber}"); // get

            #endregion

            #region Read-Only Property

            //BankAccount acc04 = new BankAccount();
            ////acc04.Balance = 1000; // Error: Cannot set read-only property
            //Console.WriteLine($"Balance: {acc04.Balance}"); // get

            #endregion

            #region Write-Only Property

            //BankAccount account2 = new BankAccount();
            //account2.Name = "Alice"; // set
            ////Console.WriteLine($"Name: {account2.Name}"); // Error: Cannot get write-only property

            #endregion

            #region Property with Private Setter

            //BankAccount account2 = new BankAccount();
            ////account2.pin = 1234; // Error: Cannot set property with private setter
            //Console.WriteLine($"PIN: {account2.pin}"); // get

            #endregion

            #region Computed Property

            //BankAccount account2 = new BankAccount();
            //account2.SetBalance(500); // Set balance using method
            //Console.WriteLine($"Has Balance: {account2.HasBalance}"); // get computed property


            #endregion

            #region Init Property

            //BankAccount account = new BankAccount { Pin2 = 5678 }; // set during initialization
            ////account.Pin2 = 5678; // set during initialization
            //Console.WriteLine($"PIN2: {account.Pin2}"); // get

            #endregion



            #endregion
        }
    }
} 