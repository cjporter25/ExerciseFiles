using System;
// Basic framework of C# to work from

namespace ProgChallenge
// Namespace refers to the project container
{
    public class BankAccount
    // Remember the keyword public before "class"
    {
        // Member Variables and properties
        private string _fname; // First name
        private string _lname; // Last name

        // Object property refering to the account's balance
        public decimal Balance {
            get; set;
        }

        // BankAccount Constructor that saves the first and last name while 
        //      also saving the initial balance, or setting it to zero if
        //      not initial balance is provided.
        public BankAccount(string fname, string lname, decimal initial=0.0m){
            _fname = fname;
            _lname = lname;
            Balance = initial;
        }

        // When refering to the "AccountOwner" Property, return an interpolated
        //      string containing the first and last name
        public string AccountOwner {
            get => $"{_fname} {_lname}";
        }

        // Default virtual "Deposit" method for all accounts. Adds the incoming
        //      amount to the current balance total.
        public virtual void Deposit(decimal amount) {
            Balance += amount;
        }

        //Default virtual "Withdraw" method for all accounts. Withdraws the
        //      requested amount from the current balance total
        public virtual void Withdraw(decimal amount) {
            Balance -= amount;
        }




    }



}