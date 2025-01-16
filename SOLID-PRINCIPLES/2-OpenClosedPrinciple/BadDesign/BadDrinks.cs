

namespace SOLID_PRINCIPLES._2_OpenClosedPrinciple.BadDesign
{
    public class BadDrinks
    {
        public enum DrinkType
        {
            Water, Coffee, Tea
        }

        public double GetTotalPrice(double amount, DrinkType drinkType)
        {
            double totalPrice = 0;
            if (drinkType == DrinkType.Water)
            {
                totalPrice += amount * 5.00;

            }
            else if (drinkType == DrinkType.Coffee)
            {
                totalPrice += amount * 9.25;

            }
            else if (drinkType == DrinkType.Tea)
            {
                totalPrice += amount * 3.50;
            }
            return totalPrice;
        }
    }
}
