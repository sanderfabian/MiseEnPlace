using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using MiseEnPlace.Model;
using System.Threading.Tasks;

namespace MiseEnPlace.ViewModels
{
    public class SelectionPageViewModel : BaseViewModel
    {
        private const string apiKey = "700d5c31506842aaxxxxxxxxxxxx"; //ADD SPOONACULAR API KEY HERE
        private string query;

        public SelectionPageViewModel(string query)
        {
            this.query = query;

            if (query == null)
            {

            }
            else
            {
                _ = ApiCalling(this.query);
            }



        }




        public async Task ApiCalling(string query)
        {
            string url = $"https://api.spoonacular.com/food/ingredients/search?query={query}&apiKey={apiKey}";

            var response = await Client.GetAsync(url);
            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();
            var tags = JsonConvert.DeserializeObject<Results>(json);
            resultsTags = tags;
        }


        private Results myResultsTags;

        public Results resultsTags
        {
            get => myResultsTags;
            set
            {
                myResultsTags = value;
                OnPropertyChanged();
            }
        }


    }
}
