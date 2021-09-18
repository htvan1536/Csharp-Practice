/*
* @Author: Van Huynh
* @Date:   2021-09-17 18:01:52
* @Last Modified by:   Van Huynh
* @Last Modified time: 2021-09-17 18:34:09
*/

/**
 * A Lead Foot Auto Rental has a mix customers from Europe and 
 * the U.S., so for customer convenience, the Manager would like 
 * to a conversion table that compares kilometers to miles.  
 * Write a program that uses an Iterative statement 
 * (While, For, or Do While - Just choose 1) to compute/print 
 * a table of values for the Manager. 

The "table" should always start at 0 KM and never exceed 200 KM.
Ask the user to enter a KM-Increment value, an integer 
value between 10 and 25 that will be used to increment 
KM's in each row.  For example, if the user enters a 10, 
then then first row will be 0 KM (starting value), the 2nd 
row will show 10 KM, the 3rd row 20 KM, etc.  To convert KM's
to Miles multiply the KM value by 0.621371.

For example:

Kilometer Increment Value = XX

Kilometers      Equiv Miles

    XX                   XX.X
    XX                   XX.X  (multiple rows)
*/

using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("**********************************************");
		Console.WriteLine("Greetings, this is Distance Conversion Manager!");
		Console.WriteLine("**********************************************\n");
		
		// 1. Input
		int userInput; //must be declared outside of do-while loop
    	do {
			Console.WriteLine("Please enter an INTEGER as KM-increment(10 - 25): ");
			userInput = Convert.ToInt32(Console.ReadLine());
			if(userInput < 10 || userInput > 25)
			{
				Console.WriteLine("Bruhhhh, I said in the range of (10 - 25)....haizzz...meh...");
				Console.WriteLine();
			}
			else  break;
    	}while(true); // "true" here means the loops ends only when user input the correct number
    
    	// 2. Calculation
		Console.WriteLine("BEHOLD, THE GREATEST CREATION.....\n");
		Console.WriteLine("*******************************************************");
		Console.WriteLine("Provided that Kilometer Increment Value = " + userInput + "\n");
		Console.WriteLine("Kilometers \t Equity Miles \n");
		double mileValue = 0;
		double kiloValue = 0;
		while(kiloValue <= 200)
		{
			mileValue = kiloValue*0.621371;
			Console.WriteLine(kiloValue + "\t\t\t\t" + mileValue);
			kiloValue = kiloValue + userInput;
		}
	}
}