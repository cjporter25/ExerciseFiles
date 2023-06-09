using System;

namespace ProgChallenge 
{
    class CheckingAcct : BankAccount
    {
        // Establish a constant member variable for the amount that is
        //  to be charged after the acct was overdrawn.
        private const decimal OVERDRAW_CHARGE = 35.0m;

        public CheckingAcct(string fname, string lname, decimal initial)
            : base(fname, lname, initial) {

        }

        public override void Withdraw (decimal amount) {
            // If the requested amount is too large, apply the overdraw
            //  charge to the total.
            if (amount > Balance) {
                amount += OVERDRAW_CHARGE;
            }
            // Now withdraw the new total (going into the negative)
            base.Withdraw(amount);
        }

    }
}