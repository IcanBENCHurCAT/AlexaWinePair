using System;
namespace WinePairLambda.Core.Models.Foods
{
    
    public class RedMeat : IFood
    {
        public string Name => "Red Meat";
        public FoodStyle Style => FoodStyle.Meat;
    }

    public class CuredMeat : IFood
    {
        public string Name => "Cured Meat";
        public FoodStyle Style => FoodStyle.Meat;
    }

    public class Pork : IFood
    {
        public string Name => "Pork";
        public FoodStyle Style => FoodStyle.Meat;
    }

    public class Poultry : IFood
    {
        public string Name => "Poultry";
        public FoodStyle Style => FoodStyle.Meat;
    }

    public class Mollusk : IFood
    {
        public string Name => "Mollusk";
        public FoodStyle Style => FoodStyle.Meat;
    }

    public class Fish : IFood
    {
        public string Name => "Fish";
        public FoodStyle Style => FoodStyle.Meat;
    }

    public class Shellfish : IFood
    {
        public string Name => "Shellfish";
        public FoodStyle Style => FoodStyle.Meat;
    }
}
