using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MiseEnPlace.Model
{
    public class Recipe
    {
        [JsonProperty("id")]

        public int Id { get; set; }
        [JsonProperty("image")]

        public string Image { get; set; }

        [JsonProperty("imageType")]
        public string ImageType { get; set; }

        [JsonProperty("likes")]
        public int Likes { get; set; }

        [JsonProperty("missedIngredientCount")]
        public int MissedIngredientCount { get; set; }

        [JsonProperty("missedIngredient")]
        public List<MissedIngredient> MissedIngredients { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("unusedIngredients")]
        public List<UnusedIngredient> UnusedIngredients { get; set; }
        public int UsedIngredientCount { get; set; }

        [JsonProperty("usedIngredients")]
        public List<UsedIngredient> UsedIngredients { get; set; }

        public static implicit operator Recipe(List<Recipe> v)
        {
            throw new NotImplementedException();
        }
    }
}
