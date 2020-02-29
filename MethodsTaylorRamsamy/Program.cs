using System;

namespace MethodsTaylorRamsamy
{
	class Program
	{
		
		static int Addition(int number1, int number2)
		{
			int sum_total;
				sum_total = number1 + number2;
			return sum_total;
		}

		static int Subtraction(int number1, int number2)
		{
			int diff_total;
			diff_total = number1 - number2;
			return diff_total;
		}

		static int Division (int number1, int number2)
		{

			int divide_total;
			
				
			try
			{
				int attempt;
				attempt = number1 / number2;
				return attempt;
			}
			catch (DivideByZeroException)
			{
				Console.WriteLine("You cannot divide a number by 0.");
																							
			}
			divide_total = number1 / number2;
			return divide_total;
			
			

			

		}

		static int multiplication(int number1, int number2)
		{
			int multi_total;
			multi_total = number1 * number2;
			return multi_total;
		}

		static void Main(string[] args)
		{
			Console.WriteLine("Hello! My name is Taylor Ramsamy.");

			// First Number Input
			Console.WriteLine("Please enter a number here:");
			String First_NumberInput;
			First_NumberInput = Console.ReadLine();
			int First_Number;
			First_Number = Convert.ToInt32(First_NumberInput);
			
			// Second Number Input
			Console.WriteLine("Please enter a second number here:");
			String Second_NumberInput;
			Second_NumberInput = Console.ReadLine();
			int Second_Number;
			Second_Number = Convert.ToInt32(Second_NumberInput);

			// Flag Number Input
			Console.WriteLine("The flags for Operations are as follows...");
			Console.WriteLine(" 1 for Addition");
			Console.WriteLine(" 2 for Subtraction");
			Console.WriteLine(" 3 for Division");
			Console.WriteLine(" 4 for Multiplication");
			Console.WriteLine("Please enter the flag of the operation you wish to have the system complete:");

			String Flag_NumberInput;
			Flag_NumberInput = Console.ReadLine();
			int Flag_Number;
			Flag_Number = Convert.ToInt32(Flag_NumberInput);

			
			switch(Flag_Number)
			{
				case 1:
					Console.WriteLine("The sum of " + First_Number + " And " + Second_Number + " Is : " + Addition(First_Number, Second_Number));
					break;

				case 2:
					Console.WriteLine("The difference between " + First_Number + " And " + Second_Number + " Is : " + Subtraction(First_Number, Second_Number));
					break;

				case 3:
					
						
					Console.WriteLine("The division of " + First_Number + " And " + Second_Number + " results in : " + Division(First_Number, Second_Number));
					
					break;

				case 4:
					Console.WriteLine("The multiplication of " + First_Number + " And " + Second_Number + " Is : " + multiplication(First_Number, Second_Number));
					break;

				default:
					Console.WriteLine("That character is not a flag. Please enter a flag.");
					Flag_NumberInput = Console.ReadLine();
					Flag_Number = Convert.ToInt32(Flag_NumberInput);
					switch (Flag_Number)
					{
						case 1:
							Console.WriteLine("The sum of " + First_Number + " And " + Second_Number + " Is : " + Addition(First_Number, Second_Number));
							break;

						case 2:
							Console.WriteLine("The difference between " + First_Number + " And " + Second_Number + " Is : " + Subtraction(First_Number, Second_Number));
							break;

						case 3:


							Console.WriteLine("The division of " + First_Number + " And " + Second_Number + " results in : " + Division(First_Number, Second_Number));

							break;

						case 4:
							Console.WriteLine("The multiplication of " + First_Number + " And " + Second_Number + " Is : " + multiplication(First_Number, Second_Number));
							break;
					}
					break;
			}
		}

	}
}
