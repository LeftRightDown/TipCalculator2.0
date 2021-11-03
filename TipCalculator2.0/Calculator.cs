//By Zachary Tan

using System;
using System.Collections.Generic;
using System.Text;
 
namespace TipCalculator2._0
{
    class Calculator
    {
      
            double tipPrecent;
            double bill;


            public Calculator()
            {

                //Calculate
                Console.Title = "Tip Calculator";
                GetBillTotal();
            }
            private void GetBillTotal()
            {
             //Get the bill amount from the user
             //Console.WriteLine("What was your total?");
            //Validate the value from the user to make sure it is a number 

             double bill = Utility.GetUserBillTotal("What was your total?");
           
            Console.Clear();
             GetTipPrecentage(tipPrecent, bill);
            }

            //Ask the user how much they want to tip - show 10,15,20 percent options
            private void GetTipPrecentage(double tipPrecent, double bill)
            {

             string[] tips = { "10%", "15%", "20%" };
            int userChoice = Utility.ShowUserTipOptions("How much would you like to tip?", tips);
             
            
                switch (userChoice)
                {
                    case 1:
                    CalculateTip(bill, 0.10);
                        break;
                     case 2:
                    CalculateTip(bill, 0.15);
                        break;
                    case 3:
                    CalculateTip(bill, 0.20);
                        break;
                }                   
              string input = Console.ReadLine();
              CalculateTip(tipPrecent, bill);
            }
        
               //Calculate tip amount from the bill amount and the percentage user chooses.
               private void CalculateTip(double bill, double tipPrecent)
               {
                double tipAmount = bill * tipPrecent;
                double finalTotal = bill + tipAmount;
                DisplayTotal(tipPrecent, bill, tipAmount, finalTotal);
               }
                
           
            //Show the final bill = bill amount + tip amount
            public void DisplayTotal(double tipPrecent, double bill,double tipAmount, double finalTotal)
            {

                if (tipAmount <= 0)
                {
                    //No Tip
                    Console.WriteLine($"Your current Total is: {bill:C}");

                }
                else if (tipAmount > 0)
                {
                    //Tip
                    Console.WriteLine($"Your Tip: {tipPrecent}%");
                    Console.WriteLine($"Your current Total is: {bill:C}");
                    Console.WriteLine($"Your current Total + Tip is: {finalTotal:C}");
                }
            }



        
    }
}

