using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Mundipagg.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class CreateCancelChargeRequest
    {
        public int? Amount { get; set; }

        public List<CreateCancelChargeSplitRulesRequest> SplitRules { get; set; }
    }
}