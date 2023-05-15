using Bunifu.UI.WinForms.Helpers.Transitions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;

namespace CurrencyConverter.Services;

public interface IExchangeCurrencyService
{
    public Task<decimal> ConvertAmountCommand(decimal SourceAmount, string SourceCurrency, string targetCurrency);
    public Task<List<string>> GetCurrenciesQuery();
}

public class ConvertResponseData
{
    [JsonProperty("result")]
    public decimal result { get; set; }
}

public class GetCurrenciesResponseData
{
    [JsonProperty("symbols")]
    public Dictionary<string, string> symbols { get; set; }
}

public class ExchangeCurrencyService : IExchangeCurrencyService
{
    private HttpClient _httpClient;

    public ExchangeCurrencyService()
    {
        _httpClient = new HttpClient();
        _httpClient.DefaultRequestHeaders.Add("apikey", "TRTK6ZainQo5xIQmwdyOqcr9gBEo3di6");
    }

    public async Task<decimal> ConvertAmountCommand(decimal SourceAmount, string SourceCurrency, string targetCurrency)
    {
        string apiUrl = "https://api.apilayer.com/exchangerates_data/" +
            $"convert?to={targetCurrency}" +
            $"&from={SourceCurrency}" +
            $"&amount={SourceAmount}";

        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            var jsonResponseContent = JsonConvert.DeserializeObject<ConvertResponseData>(responseBody);

            if (jsonResponseContent == null)
                throw new Exception("Json cannot be null");

            return jsonResponseContent.result;
        }
        else
        {
            throw new Exception("Error: " + response.StatusCode);
        }
    }

    public async Task<List<string>> GetCurrenciesQuery()
    {
        List<string> listCurrencies = new List<string>();

        string apiUrl = $"https://api.apilayer.com/exchangerates_data/symbols";

        HttpResponseMessage response = await _httpClient.GetAsync(apiUrl);

        if (response.IsSuccessStatusCode)
        {
            string responseBody = await response.Content.ReadAsStringAsync();
            var jsonResponseContent = JsonConvert.DeserializeObject<GetCurrenciesResponseData>(responseBody);

            if (jsonResponseContent == null)
                throw new Exception("Json cannot be null");

            foreach (KeyValuePair<string, string> symbol in jsonResponseContent.symbols)
            {
                string line = $"{symbol.Key}";
                listCurrencies.Add(line);
            }

            return listCurrencies;
        }
        else
        {
            throw new Exception("Error: " + response.StatusCode);
        }
    }
}
