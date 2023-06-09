using System;

namespace ProgChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. There are CheckingAcct's and SavingsAcct's
            //      CheckingAccts --> "firstName, lastName, balance"
            //      SavingsAccts --> "firstName, lastName, interestRate, balance"
            //2. Both accounts have the property "Balance"
            //      Referring to the balance will retrieve the current balance
            //3. Both accounts have the property "AccountOwner"
            //      This property displays the entire name (F|L) of the owner
            //4. The user can deposit money into either account
            //      This is done using the method "Deposit"
            //5. The user can withdraw money from either account
            //      This is done using the method "Withdraw"
            //          SAVINGS - Can not withdraw more that three times. If done
            //                    there should be a 2.00 charge on that account.
            //          SAVINGS - The savings account can not be overdrawn. If done
            //                    the transaction should be denied and print a message
            //          CHECKING - Can be overdrawn. If done, however, the owner is
            //                     charged a one-time 35$ fee for that transaction
            //6. The SavingsAcct can apply interest
            //      First calculate the interest, then add and save the new total
            // OUTPUT SHOULD LOOK LIKE:
            /*
                Checking balance is $2,500.00
                Savings balance is $1,000.00
                Checking owner: John Doe
                Savings owner: Jane Doe
                Checking balance is $2,700.00
                Savings balance is $1,150.00
                Checking balance is $2,650.00
                Savings balance is $1,025.00
                Savings balance is $1,050.63
                More than 3 withdrawals - extra charge
                Savings balance is $988.63
                Attempt to overdraw savings - denied
                Checking balance is ($385.00)
                Savings balance is $988.63
            */




        // Create the Checking Account with initial balance
            CheckingAcct checking = new CheckingAcct("John", "Doe", 2500.0m);

        // Create the Savings Account with interest and initial balance
            SavingsAcct saving = new SavingsAcct("Jane", "Doe", 0.025m, 1000.0m);

        // Check the balances
        // Expected output should be 2500 and 1000 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

        // Print the account owner information. Expected output: 
        // "Checking owner: John Doe"
        // "Savings owner: Jane Doe"
            Console.WriteLine($"Checking owner: {checking.AccountOwner}");
            Console.WriteLine($"Savings owner: {saving.AccountOwner}");

        // Deposit some money in each account
            checking.Deposit(200.0m);
            saving.Deposit(150.0m);

        // Check the balances
        // Expected output should be 2700 and 1150 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

        // Make some withdrawals from each account
            checking.Withdraw(50.0m);
            saving.Withdraw(125.0m);

        // Check the balances
        // Expected output should be 2650 and 1025 at this point
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

        // Apply the Savings interest
            saving.ApplyInterest();
        // Savings balance should now be 1050.63 
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

        // More than 3 Savings withdrawals should result in 2.00 charge
            saving.Withdraw(10.0m);
            saving.Withdraw(20.0m);
            saving.Withdraw(30.0m);
        // Savings balance should now be 988.63
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");

        // try to overdraw savings - this should be denied and print message
            saving.Withdraw(2000.0m);

        // try to overdraw checking - should result in extra charge
            checking.Withdraw(3000.0m);
            
        // Expected output should be -385 and 988.63
            Console.WriteLine($"Checking balance is {checking.Balance:C2}");
            Console.WriteLine($"Savings balance is {saving.Balance:C2}");
        }
    }
}
