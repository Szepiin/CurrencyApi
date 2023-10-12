using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyApi.DTO;

public class JSON_Historical
{
    [JsonProperty("data")]

    public Dictionary<DateTime, Dictionary<string, decimal>> Data = new Dictionary<DateTime, Dictionary<string, decimal>>();
    
}
