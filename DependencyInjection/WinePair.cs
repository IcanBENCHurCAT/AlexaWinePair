using System;
using WinePairLambda.Core.Models;
using WinePairLambda.Core.Models.Wines;
using WinePairLambda.Core.Models.Foods;
using System.Collections.Generic;

namespace WinePairLambda.DependencyInjection
{
    public class WinePair : IWinePairService
    {
        private List<IFood> _allFood;
        private List<IWine> _allWine;
        private Random _rand;
        public WinePair()
        {
            _rand = new Random();
            _allFood = new List<IFood>
            {
                new RedMeat(),
                new CuredMeat(),
                new Pork(),
                new Poultry(),
                new Mollusk(),
                new Fish(),
                new Shellfish(),
            };
            _allWine = new List<IWine>
            {
                new Malbec(),
                new CabSav(),
                new Syrah(),
                new Bordeaux(),
                new Merlot(),
                new Barbera(),
                new Sanglovese(),
                new PinotNoir(),
                new StLaurent(),
                new WhiteZin(),
                new SyrahRose(),
                new Chardonnay(),
                new Marsanne(),
                new SavBlanc(),
                new PinotGris(),
                new Champagne(),
                new SparklingWine(),
                new Moscato(),
                new Riesling(),
                new Port(),
                new Sherry(),
            };
        }
        List<IWine> IWinePairService.FindBestMatchingWines(IFood food)
        {

            List<IWine> bestMatch = new List<IWine>();
            if(food == null)
            {
                food = new Poultry();
                Console.WriteLine("Defaulting to Chicken");
            }
            FillWineLists(food, bestMatch, null);

            return bestMatch;
        }
        List<IWine> IWinePairService.FindAllMatchingWines(IFood food)
        {
            if (food == null)
                return null;

            List<IWine> bestMatch = new List<IWine>();
            List<IWine> okMatch = new List<IWine>();
            FillWineLists(food, bestMatch, okMatch);

            bestMatch.AddRange(okMatch);

            return bestMatch;
        }

        void FillWineLists(IFood food, List<IWine> bestMatch, List<IWine> okMatch)
        {

            foreach (var wine in _allWine)
            {
                foreach (var match in wine.FoodScores)
                {
                    if (match.Item1.Name == food.Name)
                    {
                        if (match.Item2 == 2 && bestMatch != null)
                            bestMatch.Add(wine);
                        else if (match.Item2 == 1 && okMatch != null)
                            okMatch.Add(wine);
                    }
                }
            }
        }

        IWine IWinePairService.FindMatchingWine(IFood food)
        {
            if (food == null)
                return _allWine[_rand.Next(0, _allWine.Count - 1)];

            foreach (var wine in _allWine)
            {
                foreach (var match in wine.FoodScores)
                {
                    if (match.Item1.Name == food.Name && match.Item2 == 2)
                    {
                        return wine;
                    }
                }
            }


            return _allWine[_rand.Next(0, _allWine.Count - 1)];
        }
    }
}