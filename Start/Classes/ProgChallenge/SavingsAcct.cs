using System;

namespace ProgChallenge
{
    class SavingsAcct : BankAccount 
    {
        // Member variable to track the number of withdraws that have occurred
        private int _withdrawcount = 0;

        // Constant defining the max number of withdraws on a savings acct
        private const decimal WITHDRAW_LIMIT = 3;

        // Constant for the charge that occurs when a savings acct is withdrawn
        //      too many times.
        private const decimal WITHDRAW_CHARGE = 2.0m;

        // Savings Acct. Constructor - The only unique element to establish during
        //      acct creation is the interest rate.
        public SavingsAcct(string fname, string lname, decimal interest, decimal initial)
            : base(fname, lname, initial) {
                InterestRate = interest;
            }
        
        // Define the InterestRate Property
        public decimal InterestRate {
            get; set;
        }

        // Method for accruing interest on the savings acct
        public void ApplyInterest() {
            Balance += (Balance * InterestRate);
        }

        public override void Withdraw(decimal amount) {
            // Prevent overdraws
            if (amount > Balance) {
                Console.WriteLine("Denied - Unable to overdraw Savings Acct");
            } else {
                // If not overdrawing, withdraw the requested amount
                base.Withdraw(amount);

                // Increment the withdraw counter
                _withdrawcount++;

                if (_withdrawcount > WITHDRAW_LIMIT) {
                    Console.WriteLine("More than 3 withdrawls occurred - issuing $2.00 charge");
                    base.Withdraw(WITHDRAW_CHARGE);
                }
            }
        }
    }
}