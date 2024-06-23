using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using MiseEnPlace.Model;
using Newtonsoft.Json;

namespace MiseEnPlace.ViewModels
{
    public  class ResultPageViewModel : BaseViewModel // experiment on MVVM, creating a individual baseviewmodel to notify when property changes
    {
        private const string apiKey = "700d5c31506842aaxxxxxxxxxxxx"; //ADD SPOONACULAR API KEY HERE
        
        private bool _isBusy;
        public bool IsBusy
        {
            get => _isBusy;
            set
            {
                _isBusy = value;
                OnPropertyChanged();
            }
        }
        private int _activityHeight;
        public int ActivityHeight
        {
            get => _activityHeight;
            set
            {
                _activityHeight = value;
                OnPropertyChanged();
            }

        }
        public  ResultPageViewModel(string query) //constructor taking it http client and search query as a arguments. 
        {
             _= ApiCalling(query); // query as a argument for search query
        }
        public async Task ApiCalling(string query)
        {
            IsBusy= true;
            ActivityHeight = 600;
            string recipeURL = $"https://api.spoonacular.com/recipes/findByIngredients?ingredients={query}&number=2&apiKey={apiKey}"; // setting query request along with API key 
            try
            {
                var recipeResponse = await Client.GetAsync(recipeURL);
                // using await, so that method will not continue until http request and response is received
                recipeResponse.EnsureSuccessStatusCode(); //response status in the range of 200-299 if not a exception will be displayed
                var recipeJson = await recipeResponse.Content.ReadAsStringAsync(); // response content is read as a string 
                var recipeTags = JsonConvert.DeserializeObject<List<Recipe>>(recipeJson); // Newtonsoft Package to deserialize json to a list of object
                MyRecipes = recipeTags;

                List<FullRecipe> recipeDetails = new List<FullRecipe>();

                foreach (var recipe in recipeTags)
                {
                    string id = recipe.Id.ToString();
                    Console.WriteLine(id);
                    string detailsURL = $"https://api.spoonacular.com/recipes/{id}/information?apiKey={apiKey}";
                    try
                    {
                        var detailsResponse = await Client.GetAsync(detailsURL);
                        detailsResponse.EnsureSuccessStatusCode();
                        var detailsJson = await detailsResponse.Content.ReadAsStringAsync();
                        var details = JsonConvert.DeserializeObject<FullRecipe>(detailsJson);
                        recipeDetails.Add(details);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error retrieving recipe details: {ex.Message}");
                    }
                }


                foreach (var recipe in recipeDetails)
                {
                    string summary = recipe.Summary;
                    summary = Regex.Replace(summary, "<.*?>", string.Empty); // Remove all HTML tags
                    recipe.Summary = summary;
                }
                foreach (var recipe in recipeDetails)
                {
                    foreach (var ingredient in recipe.ExtendedIngredients)
                    {
                        string name = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(ingredient.Name.ToLower());
                        ingredient.Name = name;
                    }
                }

                MyRoots = recipeDetails;
                IsBusy = false;
                ActivityHeight = 0;
            }
            catch (Exception ex) // if exception,display the error retrieving
            {
                Console.WriteLine($"Error retrieving Recipes {ex.Message}");
            }
        }

        private List<Recipe> _myRecipes;
        private List<FullRecipe> _myRoots;

        private FullRecipe myDetails;
        public FullRecipe MyDetails
        {
            get => myDetails;
            set
            {
                myDetails = value;
                OnPropertyChanged(nameof(MyDetails));
            }
        }
        public List<Recipe> MyRecipes
        {
            get => _myRecipes;
            set
            {
                _myRecipes = value;
                OnPropertyChanged();
            }
        }
        public List<FullRecipe> MyRoots
        {
            get => _myRoots;
            set
            {
                _myRoots = value;
                OnPropertyChanged();
            }
        }


    }
}
