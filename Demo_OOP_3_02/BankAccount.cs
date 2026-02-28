using System;
using System.Collections.Generic;
using System.Text;

namespace Demo_OOP_3_02
{
    internal class BankAccount
    {
        #region Fields
        
        // _ means is a field
        private int _AccountNumber;
        private decimal _Balance;
        private string _Name;

        #endregion

        #region Encapsulation Using Getter and Setter Methods

        public decimal GetBalance()
        {
            return _Balance;
        }

        public void SetBalance(decimal balance)
        {
            if (balance < 0)
            {
                Console.WriteLine("Balance cannot be negative !");
                return;
            }
            _Balance = balance;
        }

        public int GetAccountNumber() // Readonly
        {
            return _AccountNumber;
        }

        public void SetName(string name)
        {
            _Name = name;
        }

        #endregion

        #region Encapsulation Using Properties

        // Auto-implemented property
        //public int Age { get; set; }
        //private int _year;

        //public int Year
        //{
        //    get { return _year; }
        //    set { _year = value;}
        //}

        public string _name
        {
            get {  return _Name; }
            set {
                if(string.IsNullOrWhiteSpace(value) || value.Length < 3)
                {
                    Console.WriteLine("Invalid Name !");
                    return;
                }
                _Name = value; 
            }
        }

        #endregion

        #region Property Types

        #region Read/Write Property
            
            public int AccountNumber
            {
                get { return _AccountNumber; }
                set { _AccountNumber = value; }
            }

        #endregion

        #region Read-Only Property
        public decimal Balance
        {
            get { return _Balance; }
        }
        #endregion

        #region Write -Only Property

        public string Name
        {
               set { _Name = value; }
        }

        #endregion

        #region Automatic Property

        // CLR will create a backing field for name

        public string Name2 { get; set; }

        #endregion

        #region Property with Private Setter

        public int pin { get; private set; }
        #endregion

        #region Computed Property

       public bool HasBalance
        {
            get { return _Balance > 0; }
        }

        #endregion

        #region Init Property

        public int? Pin2 { get; init; }

        #endregion

        #region Expression-bodied Property
        public int age { get; set; }
        public int Year => DateTime.Now.Year - age;

        #endregion

        #endregion
    }
}
