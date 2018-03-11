/*C# Program - To calculate a meal cost of the food in the hotel*/
using System;
namespace Rextester
{
    public class Program
    {
        public static void Main(string[] args)
        {
	double totalcost;
	double meal_cost = Convert.ToDouble(Console.ReadLine());
        int tip_percent = Convert.ToInt32(Console.ReadLine());
        int tax_percent = Convert.ToInt32(Console.ReadLine());
	double a=Convert.ToDouble(tip_percent);
	double b=Convert.ToDouble(tax_percent);
        double c=meal_cost*a/100;
        double d=meal_cost*b/100;
        totalcost =meal_cost+c+d;
	Console.WriteLine(totalcost);
        totalcost = Math.Round(totalcost, 0);
        Console.WriteLine(totalcost);
         }
    }
}
