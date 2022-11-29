namespace ReFactored_ATM_Console_App
{
    public class English
    {
        public int accountNumber = 554433221;
        public int pin = 1984;
        public double balance = 5000000.00;
        public double transferAmount;
        public double withdrawAmount;
        public int option;
        private string userName = "Steph Curry";
        private string recipient = "Paul George";
        private int transferAccountNum = 112233445;

        public void OperationInEnglish()
        {
            try { 
                startOver:
            Console.Write("ENTER ACCOUNT NUMBER : ");
            accountNumber = Convert.ToInt32(Console.ReadLine());
            if (accountNumber != 554433221)
            {
                Console.WriteLine("\n");
                Console.WriteLine("INCORRECT ACCOUNT NUMBER ");
                    goto startOver;
            }
            else
            {
                Console.Write("ENTER ATM PIN # : ");
                pin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");
                if (pin != 1984)
                {
                    Console.WriteLine("INCORRECT PIN NUMBER PLEASE TRY AGAIN");
                        goto startOver;
                }
                else if (pin == 1984)
                {
                    while (true)
                    {
                        Console.WriteLine("=================================");
                        Console.WriteLine($"Welcome back {userName}!");
                        Console.WriteLine("CHOOSE TRANSACTION: 1, 2, 3\n");
                        Console.WriteLine("1. INQUIRE\n");
                        Console.WriteLine("2. WITHDRAW\n");
                        Console.WriteLine("3. TRANSFER\n");
                        Console.WriteLine("4. EXIT PROGRAM \n");
                        Console.Write("CHOOSE TRANSACTION : ");
                        option = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("\n");
                        if (option == 1)
                        {
                            Console.WriteLine("ACCOUNT NUMBER : " + accountNumber);
                            Console.WriteLine("ACCOUNT NAME : " + userName);
                            Console.WriteLine("BALANCE : N " + balance);
                            Console.WriteLine("THANK YOU");
                            Console.ReadLine();
                        }
                        else if (option == 2)
                        {
                            Console.Write("ENTER AMOUNT TO WITHDRAW : ");
                            withdrawAmount = Convert.ToDouble(Console.ReadLine());
                            if (withdrawAmount > 10000.00 && withdrawAmount < 0)
                            {

                                Console.WriteLine("SORRY, WITHDRAWAL IS UP TO 10,000.00 MAXIMUM ONLY");
                                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                Console.ReadLine();
                            }
                            else
                            {
                                balance = balance - withdrawAmount;
                                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                Console.WriteLine("THANK YOU");
                                Console.ReadLine();
                            }
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("ENTER AMOUNT TO TRANSFER : ");
                            transferAmount = Convert.ToDouble(Console.ReadLine());
                            if (transferAmount > 10000.00 && transferAmount < 0)
                            {

                                Console.WriteLine("SORRY, TRANSFER AMOUNT IS 10,000.00 MAXIMUM ONLY");
                                Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Kindly input the recipient's Account Number");
                                var randomVar = Convert.ToInt32(Console.ReadLine());
                                var transferAccountNum = randomVar;
                                if (transferAccountNum != 112233445)
                                {
                                    Console.WriteLine("THAT ACCOUNT NUMBER DOES NOT EXIST!");
                                }
                                else
                                {
                                    Console.WriteLine($"YOU'VE SUCCESSFULLY TRANSFERRED {transferAmount} to {recipient}");
                                    balance = balance - transferAmount;
                                    Console.WriteLine("THIS IS YOUR REMAINING BALANCE: N " + balance);
                                    Console.WriteLine("THANK YOU");
                                    Console.ReadLine();
                                }
                            }
                        }
                        else if (option == 4)
                        {
                            Console.WriteLine("THANK YOU");
                            Console.ReadLine();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("PLEASE ENTER VALID OPTION");
                            Console.ReadLine();
                        }
                    }
                }
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error Occured:" + ex.Message);

            }
        }
    }
}
