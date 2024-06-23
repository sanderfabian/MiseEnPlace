using MiseEnPlace.ViewModels;
using MiseEnPlace.Model;
using MiseEnPlace.Pages;


namespace MiseEnPlace;

public partial class ResultPage : ContentPage
{
	private string query;

    private ResultPageViewModel resultPageViewModel;
	public ResultPage(string query)
	{
		InitializeComponent();
		this.query = query;
        resultPageViewModel = new ResultPageViewModel(this.query);
        BindingContext = resultPageViewModel;
	}
    protected override void OnAppearing() //creating an OnAppearing method to prevent httpclient issues as we are using HttpClient method more than once.
    {
        base.OnAppearing();
        //var myClient = new HttpClient();
        //Arguments are required in order to bind the view-model
       
    }
    private async void Button_Clicked(object sender, EventArgs e)
    {

        //Button clickedButton = (Button)sender;
        //Frame parentFrame = (Frame)clickedButton.Parent;
        var button = (Button)sender;
        var frame = button.Parent as Frame;
        var grid = frame.Parent as Grid;
        var frame2 = grid.Parent as Frame;
        var item = (FullRecipe)frame2.BindingContext;
        //var buttonCard = sender as Button;
        //var frame = buttonCard.Parent as FlexLayout;
        //var Id = (Label)frame.FindByName("IdHolder");
        //var IdText = Id.Text;
        // Console.WriteLine(IdText);
        var recipePage = new RecipePage(item);
        await Navigation.PushAsync(recipePage);
    }
}