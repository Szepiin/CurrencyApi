using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static CurrencyApi.DTO.JSON_Historical;

namespace CurrencyApi.DTO;

public class JSON_Latest
{
    [JsonProperty("data")]
    public Data LatestData { get; set; }
    public class Data
    {
        [JsonProperty("AUD")]
        public double AUD { get; set; }

        [JsonProperty("BGN")]
        public double BGN { get; set; }

        [JsonProperty("BRL")]
        public double BRL { get; set; }

        [JsonProperty("CAD")]
        public double CAD { get; set; }

        [JsonProperty("CHF")]
        public double CHF { get; set; }

        [JsonProperty("CNY")]
        public double CNY { get; set; }

        [JsonProperty("CZK")]
        public double CZK { get; set; }

        [JsonProperty("DKK")]
        public double DKK { get; set; }

        [JsonProperty("EUR")]
        public double EUR { get; set; }

        [JsonProperty("GBP")]
        public double GBP { get; set; }

        [JsonProperty("HKD")]
        public double HKD { get; set; }

        [JsonProperty("HRK")]
        public double HRK { get; set; }

        [JsonProperty("HUF")]
        public double HUF { get; set; }

        [JsonProperty("IDR")]
        public double IDR { get; set; }

        [JsonProperty("ILS")]
        public double ILS { get; set; }

        [JsonProperty("INR")]
        public double INR { get; set; }

        [JsonProperty("ISK")]
        public double ISK { get; set; }

        [JsonProperty("JPY")]
        public double JPY { get; set; }

        [JsonProperty("KRW")]
        public double KRW { get; set; }

        [JsonProperty("MXN")]
        public double MXN { get; set; }

        [JsonProperty("MYR")]
        public double MYR { get; set; }

        [JsonProperty("NOK")]
        public double NOK { get; set; }

        [JsonProperty("NZD")]
        public double NZD { get; set; }

        [JsonProperty("PHP")]
        public double PHP { get; set; }

        [JsonProperty("PLN")]
        public double PLN { get; set; }

        [JsonProperty("RON")]
        public double RON { get; set; }

        [JsonProperty("RUB")]
        public double RUB { get; set; }

        [JsonProperty("SEK")]
        public double SEK { get; set; }

        [JsonProperty("SGD")]
        public double SGD { get; set; }

        [JsonProperty("THB")]
        public double THB { get; set; }

        [JsonProperty("TRY")]
        public double TRY { get; set; }

        [JsonProperty("USD")]
        public double USD { get; set; }

        [JsonProperty("ZAR")]
        public double ZAR { get; set; }
    }
}


