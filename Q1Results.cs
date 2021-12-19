using System;
using System.Collections.Generic;
using System.Text;

namespace WiredBrainCoffeeSurveys.Reports
{
    public static class Q1Results
    {
        // Aggregate ratings
        public static double ServiceScore { get; set; } = 8.0;

        public static double CoffeeScore { get; set; } = 4.5;

        public static double PriceScore { get; set; } = 6.0;

        public static double FoodScore { get; set; } = 7.5;

        public static double WouldRecommend { get; set; } = 6.5;

        public static string FavoriteProduct { get; set; } = "Cappuccino";

        public static string LeastFavoriteProduct { get; set; } = "Granola";

        // Aggregate counts
        public static double NumberSurveyed { get; set; } = 500;

        public static double NumberResponded { get; set; } = 325;

        public static double NumberRewardsMembers { get; set; } = 130;

        public static List<SurveyResponse> Responses = new List<SurveyResponse>()
        {
            new SurveyResponse()
            {
                EmailAddress = "hi@gmail.com",
                CoffeeScore = 8.0,
                FoodScore = 8.2,
                PriceScore = 2,
                FavoriteProduct = "Cappuccino"
            },
            new SurveyResponse()
            {
                EmailAddress = "hi2@gmail.com",
                CoffeeScore = 7.9,
                FoodScore = 8.4,
                PriceScore = 12
            },
            new SurveyResponse()
            {
                EmailAddress = "hi3@gmail.com",
                CoffeeScore = 6.0,
                FoodScore = 7.5,
                PriceScore = 21
            },
            new SurveyResponse()
            {
                EmailAddress = "hi4@gmail.com",
                CoffeeScore = 8.5,
                FoodScore = 1.2,
                PriceScore = 23
            }
        };
    }
}
