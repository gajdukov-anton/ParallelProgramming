using System.Collections.Generic;
using System.Threading.Tasks;

namespace CurrencyRater.Service
{
    public interface ICurrencyService
    {
        List<string> GetCurrenciesFromFile( string path );
        Dictionary<string, string> GetCurrentCurrenciesRates( List<string> currencies );
        void WriteCurrenciesRatesToFile( string path, Dictionary<string, string> currenciesRates );
        Task<List<string>> GetCurrenciesFromFileAsync( string path );
        Task<Dictionary<string, string>> GetCurrentCurrenciesRatesAsync( List<string> currencies );
        Task WriteCurrenciesRatesToFileAsync( string path, Dictionary<string, string> currenciesRates );
    }
}
