using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiseEnPlace.Model
{
    public class ExtendedIngredient
    {
        [JsonProperty("aisle")]
        public string Aisle { get; set; }

        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("consitency")]
        public string Consitency { get; set; }

        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("image")]
        public string Image { get; set; }

        [JsonProperty("measures")]
        public Measures Measures { get; set; }

        [JsonProperty("meta")]
        public List<string> Meta { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("original")]
        public string Original { get; set; }

        [JsonProperty("originalName")]
        public string OriginalName { get; set; }

        [JsonProperty("unit")]
        public string Unit { get; set; }
    }

    public class Measures
    {
        [JsonProperty("metric")]
        public Metric Metric { get; set; }

        [JsonProperty("us")]
        public Us Us { get; set; }
    }

    public class Metric
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unitLong")]
        public string UnitLong { get; set; }

        [JsonProperty("unitShort")]
        public string UnitShort { get; set; }
    }

    public class ProductMatch
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("price")]
        public string Price { get; set; }

        [JsonProperty("imageUrl")]
        public string ImageUrl { get; set; }

        [JsonProperty("averageRating")]
        public double AverageRating { get; set; }

        [JsonProperty("ratingCount")]
        public double RatingCount { get; set; }

        [JsonProperty("score")]
        public double Score { get; set; }

        [JsonProperty("link")]
        public string Link { get; set; }
    }

    

    public class Us
    {
        [JsonProperty("amount")]
        public double Amount { get; set; }

        [JsonProperty("unitLong")]
        public string UnitLong { get; set; }

        [JsonProperty("unitShort")]
        public string UnitShort { get; set; }
    }

    public class WinePairing
    {
        [JsonProperty("pairedWines")]
        public List<string> PairedWines { get; set; }

        [JsonProperty("pairingText")]
        public string PairingText { get; set; }

        [JsonProperty("productMatches")]
        public List<ProductMatch> ProductMatches { get; set; }
    }

}