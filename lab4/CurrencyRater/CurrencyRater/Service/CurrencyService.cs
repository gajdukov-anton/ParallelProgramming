using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using System.Linq;
using CurrencyRater.Util;
using CurrencyRater.Model;

namespace CurrencyRater.Service
{
    public class CurrencyService : ICurrencyService
    {
        public List<string> GetCurrenciesFromFile( string path )
        {
            string currency;
            var currencies = new List<string>();
            if (File.Exists(path))
            {
                using ( var streamReader = new StreamReader( path, Encoding.GetEncoding( 1251 ) ) )
                {
                    while ( ( currency = streamReader.ReadLine() ) != null )
                    {
                        currencies.Add( currency );
                    }
                }
            }
            return currencies;
        }

        public Dictionary<string, string> GetCurrentCurrenciesRates( List<string> currencyCharCodes )
        {
            var responseStr = new WebClient().DownloadString( Constants.CURRENCY_RATING_URL );
            var result = new Dictionary<string, string>();
            var currencies = JsonConvert.DeserializeObject<Dictionary<string, Currency>>( JObject.Parse( responseStr ) [ "Valute" ].ToString() );
            currencies = FilterCurrenciesByCharCodes( currencies, currencyCharCodes );
            foreach ( var currency in currencies )
            {
                result.Add( $"{currency.Value.Nominal} {currency.Value.CharCode} по курсу", currency.Value.Value.ToString() );
            }
            return result;
        }

        public void WriteCurrenciesRatesToFile( string path, Dictionary<string, string> currenciesRates )
        {
            using ( var streamWriter = new StreamWriter( path ) )
            {
                foreach ( var currencyRate in currenciesRates )
                {
                    streamWriter.WriteLine( $"{currencyRate.Key} {currencyRate.Value}" );
                }
            }
        }

        public async Task<List<string>> GetCurrenciesFromFileAsync( string path )
        {
            string currency;
            var currencies = new List<string>();
            if ( File.Exists( path ) )
            {
                using ( var streamReader = new StreamReader( path, Encoding.GetEncoding( 1251 ) ) )
                {
                    while ( ( currency = await streamReader.ReadLineAsync() ) != null )
                    {
                        currencies.Add( currency );
                    }
                }
            }
            return currencies;
        }

        public async Task<Dictionary<string, string>> GetCurrentCurrenciesRatesAsync( List<string> currencyCharCodes )
        {
            var responseStr = await new WebClient().DownloadStringTaskAsync( Constants.CURRENCY_RATING_URL );
            var result = new Dictionary<string, string>();
            var currencies = JsonConvert.DeserializeObject<Dictionary<string, Currency>>( JObject.Parse( responseStr ) [ "Valute" ].ToString() );
            currencies = FilterCurrenciesByCharCodes( currencies, currencyCharCodes );
            foreach ( var currency in currencies )
            {
                result.Add( $"{currency.Value.Nominal} {currency.Value.CharCode} по курсу", currency.Value.Value.ToString() );
            }
            return result;
        }

        public async Task WriteCurrenciesRatesToFileAsync( string path, Dictionary<string, string> currenciesRates )
        {
            using ( var streamWriter = new StreamWriter( path ) )
            {
                foreach ( var currencyRate in currenciesRates )
                {
                    await streamWriter.WriteLineAsync( $"{currencyRate.Key} {currencyRate.Value}" );
                }
            }
        }

        private Dictionary<string, Currency> FilterCurrenciesByCharCodes( Dictionary<string, Currency> currencies, List<string> currencyCharCodes )
        {
            if ( currencyCharCodes.Count == 0 )
            {
                return currencies;
            }
            return currencies.Where( currency => currencyCharCodes.Contains( currency.Key ) ).ToDictionary( currency => currency.Key, currency => currency.Value );
        }
    }
}
