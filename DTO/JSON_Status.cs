using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApi.DTO;

public class JSON_Status
{
    [JsonProperty("account_id")]
    public long AccountId { get; set; }

    [JsonProperty("quotas")]
    public Quotas Data { get; set; }

    public class Grace
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class Month
    {
        [JsonProperty("total")]
        public int Total { get; set; }

        [JsonProperty("used")]
        public int Used { get; set; }

        [JsonProperty("remaining")]
        public int Remaining { get; set; }
    }

    public class Quotas
    {
        [JsonProperty("month")]
        public Month Month { get; set; }

        [JsonProperty("grace")]
        public Grace Grace { get; set; }
    }
}
