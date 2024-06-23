using MiseEnPlace.ViewModels;
using MiseEnPlace.Pages;
using System.Globalization;

using MiseEnPlace.Model;

using System;
using MiseEnPlace.Resources;


namespace MiseEnPlace;

public partial class SelectionPage : ContentPage
{
  

    private List<Category> categoryList;

    private readonly SelectedLabels selections;



    public SelectionPage()
    {
        InitializeComponent();
        
        
        selections = new SelectedLabels();
        categoryList = LoadCategory();
        BindingContext = categoryList;
        TagHolder.ItemsSource = categoryList;
        QuickNav.ItemsSource = categoryList;
    }

    protected override async void OnAppearing()
    {
        base.OnAppearing();





    }





    private void IngredientOnTap(object sender, EventArgs e)
    {
        var frame = sender as Frame;
        var label = (Label)frame.FindByName("TagLabel");
        var labelText = label.Text;


        if (!selections.selectedLabels.Contains(labelText))
        {
            selections.selectedLabels.Add(labelText);
            frame.BackgroundColor = Color.FromArgb("#B2A5B7");
           

        }
        else if (selections.selectedLabels.Contains(labelText))
        {
            selections.selectedLabels.Remove(labelText);
            frame.BackgroundColor = Color.FromArgb("#ffffff");


        }
        BindableLayout.SetItemsSource(TagViewer, selections.selectedLabels);
    }


    public void NavOnTap(object sender, EventArgs e)
    {
        var frame = sender as Frame;
        var label = (Label)frame.FindByName("CatName");
        int index = categoryList.FindIndex(c=> c.Name == label.Text);
        TagHolder.ScrollTo(index, position: ScrollToPosition.Start, animate: true);

    }


    public void RestartOnTap(object sender, EventArgs e)
    {
        selectionBox.Height = 100;
        Review.IsVisible = false;
        TagHolder.IsVisible = true;
        ArrowLottie.Rotation = -90;
        SelectionBoxLabel.Text = "Swipe up to review your Selection";
        selections.selectedLabels.Clear();
        TagHolder.ItemsSource = LoadCategory();
    }


    public void SelectionSwipedUp(object sender, EventArgs e)
    {
        double startHeight = 100;
        double endHeight = 750;
        uint animationLength = 200; // animation duration in milliseconds

        var animation = new Animation(v =>
        {
            selectionBox.Height = v;
        }, startHeight, endHeight);

        animation.Commit(this, "SelectionBoxAnimation", length: animationLength);
        //selectionBox.Height = 750;
        Review.IsVisible = true;
        TagHolder.IsVisible = false;
        ArrowLottie.Rotation = 90;
        
        SelectionBoxLabel.Text = "Swipe down to make Changes";
    }

    public void SelectionSwipedDown(object sender, EventArgs e)
    {
        selectionBox.Height = 80;
        Review.IsVisible = false;
        TagHolder.IsVisible = true;
        ArrowLottie.Rotation = -90;
        SelectionBoxLabel.Text = "Swipe up to review your Selection";
        
    }

    public async void OnConfirm(object sender, EventArgs e)
    {
     
       string query = string.Join(",", selections.selectedLabels.ToList());
       Console.WriteLine(query);
       var myResultPage = new ResultPage(query);
        await Navigation.PushAsync(myResultPage);
    }


    private static List<Category> LoadCategory()
    {
        List<Category> categories = new List<Category>();
        
        categories.Add(new Category
        {

            Name = "Protein",
            Items = new List<string>() { "Beef", "Chicken", "Crab", "Duck", "Fish", "Lamb", "Lobster", "Pork", "Prawn", "Protein", "Squid", "Turkey" },
            Color = Color.FromArgb("#95A8B0"),
            Image = "meat.png"
        });
        categories.Add(new Category
        {

            Name = "Vegetables",
            Items = new List<string>() { "Asparagus", "Bell peppers", "Broccoli", "Cabbage", "Carrots", "Cauliflower", "Celery", "Chilli", "Corn", "Cucumbers", "Garlic", "Green beans", "Green onions", "Lettuce", "Mushrooms", "Onions", "Potatoes", "Salad", "Spinach", "Sweet potatoes", "Tomatoes" },
            Color = Color.FromArgb("#A7B7BD"),
            Image = "vegetable.png"
        });
        categories.Add(new Category
        {

            Name = "Fruits",
            Items = new List<string>() { "Apples", "Apricots", "Bananas", "Cherries", "Figs", "Peaches", "Pears", "Pineapple", "Plums" },
            Color = Color.FromArgb("#B9C6CB"),
            Image = "harvest.png"
        });
        categories.Add(new Category
        {

            Name = "Grains",
            Items = new List<string>() { "Bread",
                    "Cereals",
                    "Grits",
                    "Pasta",
                    "Rice",
                    "Tortillas" },
            Color = Color.FromArgb("#CAD4D8"),
            Image = "grain.png"
        });
        categories.Add(new Category
        {

            Name = "Spices",
            Items = new List<string>() { "Basil",
                    "Black pepper",
                    "Cayenne pepper",
                    "Cinnamon",
                    "Cumin",
                    "Curry",
                    "Garlic powder",
                    "Nutmeg",
                    "Onion Powder",
                    "Oregano",
                    "Paprika",
                    "Parsley",
                    "Rosemary",
                    "Salt",
                    "Thyme",
                    "Vanilla",
                    "White pepper" },
            Color = Color.FromArgb("#DCE3E6"),
            Image = "spices.png"
        });
        categories.Add(new Category
        {

            Name = "Dairy Products",
            Items = new List<string>() {  "Butter",
                    "Casein",
                    "Cheese",
                    "Cream",
                    "Ice cream",
                    "Milk",
                    "Whey",
                    "Yogurt" },
            Color = Color.FromArgb("#EEF2F3"),
            Image = "dairy.png"
        });
        
        categories.Add(new Category
        {

            Name = "Others",
            Items = new List<string>() {  "Alcohol",
                     "Chocolate",
                     "Honey",
                     "Margarine",
                     "PeanutButter",
                     "Softdrinks" }
            ,
            Color = Color.FromArgb("#F0F3F4"),
            Image = "salad.png"
        });
        return categories;
    }

  

}


