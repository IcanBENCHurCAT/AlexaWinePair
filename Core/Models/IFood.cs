using System;
namespace WinePairLambda.Core.Models
{
    public enum FoodStyle
    {
        Meat,
        Preperation,
        Dairy,
        Vegetable,
        HerbSpice,
        Starch,
        Sweet

    }
    public interface IFood
    {
        string Name { get; }
        FoodStyle Style { get; }
    }
}
