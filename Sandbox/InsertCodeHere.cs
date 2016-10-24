using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line

            int amountToPay = 125;
            int paidAmount = 1000;

            int changeToPayBack = paidAmount - amountToPay;

           
            // To keep things simple, we assume that you pay back
            // change as: 1-kr coins, 10-kr coins and 100-kr bills.

            int noOf1krCoins = 0;
            int noOf10krCoins = 0;
            int noOf50krCoins = 0;
            int noOf100krBills = 0;
            int noOf200krBills = 0;


            // YOUR JOB: Add code to calculate the correct change

            while (changeToPayBack > 0)
            {
                    if (changeToPayBack >= 200)
                    {
                        noOf200krBills = changeToPayBack / 200;
                        changeToPayBack = changeToPayBack % 200;
                    }
                    else if (changeToPayBack >= 100)
                    {
                        noOf100krBills = changeToPayBack / 100;
                        changeToPayBack = changeToPayBack % 100;
                    } //while (change > 0);
                    else if (changeToPayBack >= 50)
                    {
                    noOf50krCoins = changeToPayBack / 50;
                    changeToPayBack = changeToPayBack % 50;
                    }

                    else if (changeToPayBack >= 10)
                    {
                        noOf10krCoins = changeToPayBack / 10;
                        changeToPayBack = changeToPayBack % 10;
                    }
                    else if (changeToPayBack >= 1)
                    {
                        noOf1krCoins = changeToPayBack / 1;
                        changeToPayBack = changeToPayBack % 1;
                    }

                //} while (changeToPayBack >= 0);

                Console.WriteLine("Your change is {0} 1-kr coins, {1} 10-kr coins, {2} 50-kr bills, {3} 100-kr bills and {4} 200-kr bills", noOf1krCoins, noOf10krCoins, noOf50krCoins, noOf100krBills, noOf200krBills);
                Console.WriteLine("A total of {0} kr", changeToPayBack);


                // The LAST line of code should be ABOVE this line
            }
        }
    }
}
