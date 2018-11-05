using System;
using System.Collections.Generic;
using WinePairLambda.Core.Models.Foods;

namespace WinePairLambda.Core.Models.Wines
{
    static class WineFoodMatch
    {
        public static List<Tuple<IFood, int>> BoldRed = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new RedMeat(), 2),
            new Tuple<IFood, int>(new CuredMeat(), 1),
            new Tuple<IFood, int>(new Pork(), 1),
        };

        public static List<Tuple<IFood, int>> MediumRed = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new RedMeat(), 1),
            new Tuple<IFood, int>(new CuredMeat(), 1),
            new Tuple<IFood, int>(new Pork(), 2),
            new Tuple<IFood, int>(new Poultry(), 1),
        };

        public static List<Tuple<IFood, int>> LightRed = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new CuredMeat(), 2),
            new Tuple<IFood, int>(new Poultry(), 2),
        };

        public static List<Tuple<IFood, int>> Rose = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new CuredMeat(), 1),
            new Tuple<IFood, int>(new Pork(), 1),
            new Tuple<IFood, int>(new Poultry(), 1),
        };

        public static List<Tuple<IFood, int>> RichWhite = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new Poultry(), 2),
            new Tuple<IFood, int>(new Fish(), 1),
            new Tuple<IFood, int>(new Shellfish(), 2),
        };

        public static List<Tuple<IFood, int>> LightWhite = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new Poultry(), 1),
            new Tuple<IFood, int>(new Mollusk(), 1),
            new Tuple<IFood, int>(new Fish(), 2),
            new Tuple<IFood, int>(new Shellfish(), 1),
        };

        public static List<Tuple<IFood, int>> Sparkling = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new CuredMeat(), 1),
            new Tuple<IFood, int>(new Pork(), 1),
            new Tuple<IFood, int>(new Poultry(), 1),
            new Tuple<IFood, int>(new Mollusk(), 2),
            new Tuple<IFood, int>(new Fish(), 1),
        };

        public static List<Tuple<IFood, int>> SweetWhite = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new CuredMeat(), 2),
            new Tuple<IFood, int>(new Shellfish(), 1),
        };

        public static List<Tuple<IFood, int>> Dessert = new List<Tuple<IFood, int>>
        {
            new Tuple<IFood, int>(new CuredMeat(), 1),
        };

    }
    public class Malbec : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.BoldRed;

        public string Name => "Malbec";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Malbec()
        {
            _foodScores = WineFoodMatch.BoldRed;
        }
    }

    public class CabSav : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.BoldRed;

        public string Name => "Cabernet Sauvignon";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public CabSav()
        {
            _foodScores = WineFoodMatch.BoldRed;
        }
    }

    public class Syrah : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.BoldRed;

        public string Name => "Syrah";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Syrah()
        {
            _foodScores = WineFoodMatch.BoldRed;
        }
    }

    public class Bordeaux : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.BoldRed;

        public string Name => "Bordeaux";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Bordeaux()
        {
            _foodScores = WineFoodMatch.BoldRed;
        }
    }

    public class Merlot : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.MediumRed;

        public string Name => "Merlot";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Merlot()
        {
            _foodScores = WineFoodMatch.MediumRed;
        }
    }

    public class Barbera : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.MediumRed;

        public string Name => "Barbera";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Barbera()
        {
            _foodScores = WineFoodMatch.MediumRed;
        }
    }

    public class Sanglovese : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.MediumRed;

        public string Name => "Sanglovese";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Sanglovese()
        {
            _foodScores = WineFoodMatch.MediumRed;
        }
    }

    public class PinotNoir : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.LightRed;

        public string Name => "Pinot Noir";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public PinotNoir()
        {
            _foodScores = WineFoodMatch.LightRed;
        }
    }

    public class StLaurent : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.LightRed;

        public string Name => "Saint Laurent";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public StLaurent()
        {
            _foodScores = WineFoodMatch.LightRed;
        }
    }

    public class WhiteZin : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.Rose;

        public string Name => "White Zinfandel";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public WhiteZin()
        {
            _foodScores = WineFoodMatch.Rose;
        }
    }

    public class SyrahRose : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.Rose;

        public string Name => "Syrah Rose";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public SyrahRose()
        {
            _foodScores = WineFoodMatch.Rose;
        }
    }

    public class Chardonnay : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.RichWhite;

        public string Name => "Chardonnay";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Chardonnay()
        {
            _foodScores = WineFoodMatch.RichWhite;
        }
    }

    public class Marsanne : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.RichWhite;

        public string Name => "Marsanne";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Marsanne()
        {
            _foodScores = WineFoodMatch.RichWhite;
        }
    }

    public class SavBlanc : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.LightWhite;

        public string Name => "Savignon Blanc";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public SavBlanc()
        {
            _foodScores = WineFoodMatch.LightWhite;
        }
    }

    public class PinotGris : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.LightWhite;

        public string Name => "Pinot Grigio";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public PinotGris()
        {
            _foodScores = WineFoodMatch.LightWhite;
        }
    }

    public class Champagne : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.Sparkling;

        public string Name => "Champagne";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Champagne()
        {
            _foodScores = WineFoodMatch.Sparkling;
        }
    }

    public class SparklingWine : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.Sparkling;

        public string Name => "Sparkling Wine";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public SparklingWine()
        {
            _foodScores = WineFoodMatch.Sparkling;
        }
    }

    public class Moscato : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.SweetWhite;

        public string Name => "Moscato";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Moscato()
        {
            _foodScores = WineFoodMatch.SweetWhite;
        }
    }

    public class Riesling : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.SweetWhite;

        public string Name => "Riesling";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Riesling()
        {
            _foodScores = WineFoodMatch.SweetWhite;
        }
    }

    public class Port : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.Dessert;

        public string Name => "Port";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Port()
        {
            _foodScores = WineFoodMatch.Dessert;
        }
    }

    public class Sherry : IWine
    {
        private List<Tuple<IFood, int>> _foodScores;

        public WineStyle Style => WineStyle.Dessert;

        public string Name => "Sherry";

        public List<Tuple<IFood, int>> FoodScores => _foodScores;

        public Sherry()
        {
            _foodScores = WineFoodMatch.Dessert;
        }
    }
}
