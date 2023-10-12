using CurrencyApi.DTO;
using Newtonsoft.Json;

namespace CurrencyApi;
public class Currency_Manager
{
    private static string apiKey;
    private static string url = "https://api.freecurrencyapi.com/v1/";

    public Currency_Manager(string? apiToken = "fca_live_mqSCP4YxYVtiQsj6WpKmWe2WOuuZERAzD1kaqD9U")
    {
        apiKey = apiToken;
    }

    public JSON_Status? GetStatus()
    {
        var response = Currency_Client.ExecuteRequest(url + "status" + "?apikey=" + apiKey);
        var data = JsonConvert.DeserializeObject<JSON_Status>(response.Content);
        return data;
     }

    public JSON_Currencies? GetCurrencies(string? Currencies = null)
    {
        var response = Currency_Client.ExecuteRequest(url + "currencies" + "?apikey=" + apiKey + "&currencies=" + Currencies);
        var data = JsonConvert.DeserializeObject<JSON_Currencies>(response.Content);
        return data;
    }
    public JSON_Latest? GetLatest
        (
        string? baseCurrency = "EUR",
        string? Currencies = null
        )
    {
        var response = Currency_Client.ExecuteRequest(url + "latest" + "?apikey=" + apiKey + "&base_currency=" + baseCurrency + "&currencies=" + Currencies);
        var data = JsonConvert.DeserializeObject<JSON_Latest>(response.Content);
        return data;
    }

    public JSON_Historical? GetHistorical
        (
        string? date = null,
        string? baseCurrency = "EUR",
        string? currencies = null
        )
    {
        var response = Currency_Client.ExecuteRequest(url + "historical" + "?apikey=" + apiKey + "&date=" + date + "&base_currency=" + baseCurrency + "&currencies=" + currencies);
        var data = JsonConvert.DeserializeObject<JSON_Historical>(response.Content);

        return data;
    }
}
