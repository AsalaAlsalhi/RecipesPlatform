namespace RecipePlatform.Models.Entities
{
    public class Rating
    {
        public int RatingId { get; set; }
        public int Value { get; set; }

        public int RecipeId { get; set; }
        public Recipe Recipe { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
