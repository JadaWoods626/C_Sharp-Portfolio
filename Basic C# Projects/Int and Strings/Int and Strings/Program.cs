﻿using System;

namespace Int_and_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Pick a number.");
                int numOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Pick another number.");
                int numTwo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing the two....");
                int numThree = numOne / numTwo;
                Console.WriteLine(numOne + " divided by " + numTwo + " equals " + numThree);
                Console.ReadLine();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Please type a whole number.");
                return;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
            
        }
    }
}
