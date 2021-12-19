namespace WiredBrainCoffeeSurveys.Reports
{
    public class SurveyResponse
    {
        public double ServiceScore { get; set; } = 0.0;

        public double CoffeeScore { get; set; } = 0.0;

        public double PriceScore { get; set; } = 0.0;

        public double FoodScore { get; set; } = 0.0;

        public double WouldRecommend { get; set; } = 0.0;

        public string FavoriteProduct { get; set; } = string.Empty;

        public string LeastFavoriteProduct { get; set; } = string.Empty;

        public string AreaToImprove { get; set; } = string.Empty;

        public bool IsRewardsMember { get; set; } = false;

        public string EmailAddress { get; set; } = string.Empty;

        public string Comments { get; set; } = string.Empty;
    }
}
