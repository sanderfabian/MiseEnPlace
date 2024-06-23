using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnPlace.Model
{
    public class UsedIngredient
    {
        [JsonProperty("aisle")]
        public string Aisle { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("meta")]
        public List<object> Meta { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("orginal")]
        public string Original { get; set; }

        [JsonProperty("orginalName")]
        public string OriginalName { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }

        [JsonProperty("unitlong")]
        public string UnitLong { get; set; }

        [JsonProperty("unitshort")]
        public string UnitShort { get; set; }
    }

}
