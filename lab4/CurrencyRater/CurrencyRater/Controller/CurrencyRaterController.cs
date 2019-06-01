using CurrencyRater.Service;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace CurrencyRater.Controller
{
    public class CurrencyRaterController : ICurrencyRaterController
    {
        private const int AMOUNT_LOOP = 30;
        private ICurrencyService _currencyService;

        public CurrencyRaterController()
        {
            _currencyService = new CurrencyService();
        }

        public List<long> WriteCurrencyRateToFile( string currencyFile, string resultFile )
        {
            var result = new List<long>();
            long minTime = long.MaxValue;
            for ( int i = 0; i < AMOUNT_LOOP; i++ )
            {
                var timer = Stopwatch.StartNew();
                var currencies = _currencyService.GetCurrenciesFromFile( currencyFile );
                _currencyService.WriteCurrenciesRatesToFile( resultFile, _currencyService.GetCurrentCurrenciesRates( currencies ) );
                timer.Stop();
                if (minTime > timer.ElapsedMilliseconds )
                {
                    minTime = timer.ElapsedMilliseconds;
                }
                result.Add( timer.ElapsedMilliseconds );
            }
            RemoveLongTimePeriod( result, minTime );
            return result;
        }

        public async Task<List<long>> WriteCurrencyRateToFileAsync( string currencyFile, string resultFile )
        {
            var result = new List<long>();
            long minTime = long.MaxValue;
            for ( int i = 0; i < AMOUNT_LOOP; i++ )
            {
                var timer = Stopwatch.StartNew();
                var currencies = await _currencyService.GetCurrenciesFromFileAsync( currencyFile );
                await _currencyService.WriteCurrenciesRatesToFileAsync( resultFile, await _currencyService.GetCurrentCurrenciesRatesAsync( currencies ) );
                timer.Stop();
                if ( minTime > timer.ElapsedMilliseconds )
                {
                    minTime = timer.ElapsedMilliseconds;
                }
                result.Add( timer.ElapsedMilliseconds );
            }
            RemoveLongTimePeriod( result, minTime );
            return result;
        }

        private void RemoveLongTimePeriod(List<long> timePeroids, long minTime)
        {
            for ( int i = 0; i < timePeroids.Count; i++ )
            {
                if (timePeroids[i] > minTime * 2)
                {
                    timePeroids.RemoveAt( i );
                    i--;
                }
            }
        }
    }
}
