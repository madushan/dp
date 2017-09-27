using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder2
{
    class Program
    {
        static void Main(string[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();
            Meal vegMeal = mealBuilder.PrepareVegMeal();
            Console.WriteLine("Veg Meal");
            vegMeal.ShowItems();
            Console.WriteLine("Total cost: "+vegMeal.GetCost());

            Meal nonVegMeal = mealBuilder.PrepareNonVegMeal();
            Console.WriteLine("\n\n Non-veg Meal");
            nonVegMeal.ShowItems();
            Console.WriteLine("Total cost: "+nonVegMeal.GetCost());

            Console.ReadKey();
        }
    }
}
