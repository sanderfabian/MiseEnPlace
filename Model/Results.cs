using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnPlace.Model
{
    public class Results
    {
        [JsonProperty("results")]
        public List<IngredientTag> IngredientTags { get; set; }

        [JsonProperty("offset")]
        public int Offset { get; set; }

        [JsonProperty("number")]
        public int Number { get; set; }

        [JsonProperty("totalResults")]
        public int TotalResults { get; set; }
    }

}

