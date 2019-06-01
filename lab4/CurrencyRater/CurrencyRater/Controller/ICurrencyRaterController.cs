using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurrencyRater.Controller
{
    public interface ICurrencyRaterController
    {
        List<long> WriteCurrencyRateToFile( string currencyFile, string resultFile );
        Task<List<long>> WriteCurrencyRateToFileAsync( string currencyFile, string resultFile );
    }
}
