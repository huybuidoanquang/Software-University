namespace SoftUniRestaurant.Models.Drinks.Models
{
    public class FuzzyDrink : Drink
    {
        private const decimal InitialPrice = 2.50m;

        public FuzzyDrink(string name, int servingSize, string brand)
            : base(name, servingSize, InitialPrice, brand)
        {
        }
    }
}