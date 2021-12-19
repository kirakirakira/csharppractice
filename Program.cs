using System;
// using MyUtilities; // using namespace, not the class
// using static MyUtilities.WeatherUtilities; // another way to do this with C# 6
using MyUtilities;
using WiredBrainCoffeeSurveys.Reports;

namespace MyFirstProgram
{
    class HelloWorld
    {
        public static void GenerateTasksReport()
        {
            var tasks = new List<string>();

            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");

            // Logical comparisons
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool isCoffeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;
            bool customersRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappuccino";

            Console.WriteLine($"Coffee Score Higher Than Food: {higherCoffeeScore}");
            Console.WriteLine($"Customers Would Recommend Us: {customersRecommend}");
            Console.WriteLine($"Hate Granola, Love Cappucino: {noGranolaYesCappucino}");

            if (isCoffeeScoreLower)
            {
                tasks.Add("Investigate coffee recipes and ingredients.");
            }

            if (responseRate < 0.33)
            {
                tasks.Add("Need to increase");
            }
            else if (responseRate > 0.33 && responseRate < 0.66)
            {
                tasks.Add("Free coffee");
            }
            else
            {
                tasks.Add("Discount coffee");
            }

            switch (Q1Results.FavoriteProduct)
            {
                case "Granola":
                    tasks.Add("Yum");
                    break;

                case "Cappuccino":
                    tasks.Add("Caffeine!");
                    break;

                default:
                    tasks.Add("None");
                    break;
            }
        }

        public static void GenerateWeatherReport()
        {
            Console.WriteLine("Where should we go in May?");
            WeatherUtilities.Report("San Francisco", WeatherUtilities.FahrenheitToCelsius(65), 73);
            WeatherUtilities.Report("Denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("Bologna", 23, 65);

        }
        private static float FahrenheitToCelsius(float temperatureFahreinheit)
        {
            var temperatureCelsius = (temperatureFahreinheit - 32) / 1.8f;
            Console.WriteLine("in my first program");
            return temperatureCelsius;
        }
        static void Main(string[] args)
        {
            GenerateWeatherReport();
            GenerateTasksReport();

            for (var i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i];

                if (currentResponse.CoffeeScore < 7.0)
                {
                    Console.WriteLine(currentResponse.EmailAddress);
                }
            }
        }
    }
}
