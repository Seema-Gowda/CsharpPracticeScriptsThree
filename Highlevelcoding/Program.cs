using System;

namespace Highlevelcoding
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Integer meathod!");
			int prod = multiply(3, 4, 5);
			int diff = subract(6, 2);
			addition(diff, prod);

			Console.WriteLine("String meathod!");
			MycounMeth("India");
			MycounMeth("USA");
			MycounMeth();
			human("Seema", "Gowda", 37);
			human("Umesh", "Gowda", 42);
			human("Namith", "Gowda", 09);
			mychildren(child3: "Rani", child2: "Pushpa", child1: "Latha");
			mysisters(Sis3: "sammy");

			Console.WriteLine(" Meathod overloading !");

			
			int x = methovrloadcal(2, 3);
			double y = methovrloadcal(21.2, 43.2);
			string ans = methovrloadcal("One", "Two");

			Console.WriteLine(x);
			Console.WriteLine(y);
			Console.WriteLine(ans);

			Console.ReadLine();
		}

		static void addition(int x, int y)
		{
			int sum = x + y;
			Console.WriteLine("The sum of " + x + " + " + y + "ïs" + sum);
		}

		static int multiply(int a, int b, int c)
		{
			int prod = (a * b * c);
			return prod;

		}
		static int subract(int m, int n)
		{
			return (m - n);
		}

		static void MycounMeth(string country = "Switzerland")
		{
			Console.WriteLine(country);
		}

		static void human(String FN, String LN, int Age)
		{
			Console.WriteLine("My full name is " + FN + LN + " and My Age is  " + Age);
		}

		static void mychildren( string child1, string child2, string child3)
		{

			Console.WriteLine("My First child is " + child1);
			Console.WriteLine("My Second child is " + child2);
			Console.WriteLine("My Third child is " + child3);
		}


		static void mysisters(string Sis1 = "Leela" , string Sis2 = "Kiran" , string Sis3 = "Shilpa" )

		{
			Console.WriteLine("My Sis 1 child is " + Sis1);
			Console.WriteLine("My Sis 2 child is " + Sis2);
			Console.WriteLine("My Sis 3 child is " + Sis3);

		}


		static int methovrloadcal(int x, int y)
		{
			return (x + y);
		}

		static double methovrloadcal(double x, double y)
		{
			return (x + y);

		}

		static string methovrloadcal(string x, string y)

		{
			String reply = "Enter Numbers plz";
			return reply;

		}

	}



}
