using MiseEnPlace.Model;

namespace MiseEnPlace.Pages;

public partial class RecipePage : ContentPage
{
	private FullRecipe item;
	public RecipePage(FullRecipe item)
	{
		InitializeComponent();
		this.item = item;
		BindingContext= this.item;
	}
}