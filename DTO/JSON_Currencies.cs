using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace CurrencyApi.DTO;

public class JSON_Currencies
{
    public class Currency
    {
        [JsonProperty("symbol")]
        public string Symbol { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("symbol_native")]
        public string SymbolNative { get; set; }

        [JsonProperty("decimal_digits")]
        public int DecimalDigits { get; set; }

        [JsonProperty("rounding")]
        public int Rounding { get; set; }

        [JsonProperty("code")]
        public string Code { get; set; }

        [JsonProperty("name_plural")]
        public string NamePlural { get; set; }
    }
    public class Data
    {
        [JsonProperty("EUR")]
        public Currency EUR { get; set; }

        [JsonProperty("USD")]
        public Currency USD { get; set; }

        [JsonProperty("JPY")]
        public Currency JPY { get; set; }

        [JsonProperty("BGN")]
        public Currency BGN { get; set; }

        [JsonProperty("CZK")]
        public Currency CZK { get; set; }

        [JsonProperty("DKK")]
        public Currency DKK { get; set; }

        [JsonProperty("GBP")]
        public Currency GBP { get; set; }

        [JsonProperty("HUF")]
        public Currency HUF { get; set; }

        [JsonProperty("PLN")]
        public Currency PLN { get; set; }

        [JsonProperty("RON")]
        public Currency RON { get; set; }

        [JsonProperty("SEK")]
        public Currency SEK { get; set; }

        [JsonProperty("CHF")]
        public Currency CHF { get; set; }

        [JsonProperty("ISK")]
        public Currency ISK { get; set; }

        [JsonProperty("NOK")]
        public Currency NOK { get; set; }

        [JsonProperty("HRK")]
        public Currency HRK { get; set; }

        [JsonProperty("RUB")]
        public Currency RUB { get; set; }

        [JsonProperty("TRY")]
        public Currency TRY { get; set; }

        [JsonProperty("AUD")]
        public Currency AUD { get; set; }

        [JsonProperty("BRL")]
        public Currency BRL { get; set; }

        [JsonProperty("CAD")]
        public Currency CAD { get; set; }

        [JsonProperty("CNY")]
        public Currency CNY { get; set; }

        [JsonProperty("HKD")]
        public Currency HKD { get; set; }

        [JsonProperty("IDR")]
        public Currency IDR { get; set; }

        [JsonProperty("ILS")]
        public Currency ILS { get; set; }

        [JsonProperty("INR")]
        public Currency INR { get; set; }

        [JsonProperty("KRW")]
        public Currency KRW { get; set; }

        [JsonProperty("MXN")]
        public Currency MXN { get; set; }

        [JsonProperty("MYR")]
        public Currency MYR { get; set; }

        [JsonProperty("NZD")]
        public Currency NZD { get; set; }

        [JsonProperty("PHP")]
        public Currency PHP { get; set; }

        [JsonProperty("SGD")]
        public Currency SGD { get; set; }

        [JsonProperty("THB")]
        public Currency THB { get; set; }

        [JsonProperty("ZAR")]
        public Currency ZAR { get; set; }
    }

}
