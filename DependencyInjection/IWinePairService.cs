using System.Collections.Generic;
using WinePairLambda.Core.Models;

namespace WinePairLambda.DependencyInjection
{
    public interface IWinePairService
    {
        IWine FindMatchingWine(IFood food);

        List<IWine> FindAllMatchingWines(IFood food);
        List<IWine> FindBestMatchingWines(IFood food);
    }
}
