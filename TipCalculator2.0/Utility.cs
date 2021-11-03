using System;
using System.Collections.Generic;
using System.Text;

namespace TipCalculator2._0
{
    class Utility
    {
        public static bool IsNumeric(string input)
        {
            return int.TryParse(input,out int number);
        }

        public static int GetUserBillTotal(string title)
        {
          try
          {     Console.WriteLine(title); 
                string input = Console.ReadLine();
                int bill =Convert.ToInt32(input);
                if (bill >  0)
                {

                    return bill;
                   
                }
                else 
                {
                    return bill;
                }      
          }
           catch
          {
            Console.WriteLine("You didn't enter a valid number");
          }
            return GetUserBillTotal(title);
        }
        public static int ShowUserTipOptions(string title, string[] tips)
        {
            Console.WriteLine(title);
            for (int i = 0; i < tips.Length; i++)
            {
                int number = i + 1;
                string details = $"{number}) {tips[i]}\n";
                Console.Write(details);
            }
            return GetAValidNumberFromTheUser(tips.Length);
        }
        public static int GetAValidNumberFromTheUser(int numberofOptions)
        {
            Console.WriteLine($"Please pick a number between 1 and {numberofOptions}");
            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                if (number > 0 && number <= numberofOptions)
                {
                    return number;
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Please enter a valid input");
            }
            return GetAValidNumberFromTheUser(numberofOptions);
        }
    }
}
