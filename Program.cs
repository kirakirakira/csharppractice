using System;
// using MyUtilities; // using namespace, not the class
// using static MyUtilities.WeatherUtilities; // another way to do this with C# 6
using MyUtilities;
using WiredBrainCoffeeSurveys.Reports;
using Newtonsoft.Json;
using NetCoreAudio;

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

        public static void GenerateWinnerEmails(SurveyResults results)
        {
            var selectedEmails = new List<string>();
            int counter = 0;

            while (selectedEmails.Count < 2 && counter < results.Responses.Count)
            {
                var currentItem = results.Responses[counter];

                if (currentItem.FavoriteProduct == "Cappuccino")
                {
                    selectedEmails.Add(currentItem.EmailAddress);
                    Console.WriteLine(currentItem.EmailAddress);
                }

                counter++;
            }

            File.WriteAllLines("WinnersReport.csv", selectedEmails);
        }
        private static float FahrenheitToCelsius(float temperatureFahreinheit)
        {
            var temperatureCelsius = (temperatureFahreinheit - 32) / 1.8f;
            Console.WriteLine("in my first program");
            return temperatureCelsius;
        }
        static void Main(string[] args)
        {
            bool quitApp = false;

            do
            {
                Console.WriteLine("Please pick report to run (tasks, weather, winners):");
                var selectedReport = Console.ReadLine();

                Console.WriteLine("Please specify which quarter of data: (q1, q2)");
                var selectedData = Console.ReadLine();

                var surveyResults = JsonConvert.DeserializeObject<SurveyResults>
                    (File.ReadAllText($"data/{selectedData}.json"));

                // Console.WriteLine(surveyResults.Responses[0].Comments);

                var player = new Player();

                switch (selectedReport)
                {
                    case "tasks":
                        GenerateTasksReport();
                        break;

                    case "weather":
                        GenerateWeatherReport();
                        break;

                    case "winners":
                        GenerateWinnerEmails(surveyResults);
                        break;

                    case "music":
                        player.Play("burp_x.wav");
                        break;

                    case "quit":
                        quitApp = true;
                        break;

                    default:
                        Console.WriteLine("Sorry, choose a valid option");
                        break;
                }

                Console.WriteLine();
            }
            while (!quitApp);


            for (var i = 0; i < Q1Results.Responses.Count; i++)
            {
                var currentResponse = Q1Results.Responses[i];

                if (currentResponse.CoffeeScore < 7.0)
                {
                    Console.WriteLine(currentResponse.EmailAddress);
                }
            }

            foreach (var response in Q1Results.Responses)
            {
                if (response.FoodScore == Q1Results.FoodScore)
                {
                    Console.WriteLine("bingo!");
                }
            }
        }
    }
}
