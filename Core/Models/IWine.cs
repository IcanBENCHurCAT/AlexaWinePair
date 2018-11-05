using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace WinePairLambda.Core.Models
{
    public enum WineStyle
    {
        BoldRed,
        MediumRed,
        LightRed,
        Rose,
        RichWhite,
        LightWhite,
        Sparkling,
        SweetWhite,
        Dessert
    }

    public interface IWine
    {
        WineStyle Style { get; }
        string Name { get; }

        List<Tuple<IFood, int>> FoodScores { get; }
    }
}
