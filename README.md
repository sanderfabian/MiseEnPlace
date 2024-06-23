# Mise En Place
![Overview](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/e0b92553-a2c2-41e7-82a4-05b00cf0c9f5)

## Description
Mise En Place is a .Net MAUI mobile application that uses SpoonacularAPI to retrieve recipes based on the Ingredients available to the users.
## Images
### Startup & Ingredient Selection
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/StartUp.png)
![Overview]( https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Ingredient%20selecter.png)<br>
Choose from a variety of options catalogued into distinct categories. <br>
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Beef.png)
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/SelectionReview.png)<br>
Review your selection and send it!<br>
![QuickSelect](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Quick%20Select.png)<br>
A quick Navigation option to select category pages.<br>

### Getting your Recipes
Based on your Selected tags Mise En Place will pull recipes from Spoonacular to fit your requirements
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/LoadingRecipes.png)
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Results.png)<br>
After loading, your results will be presented.<br>
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/SwipeThru.png)<br>
Swipe through your available options!

### Reading your Recipes
Recipes are displayed in detail:<br>
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Recipe1.png)
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Recipe2.png)
![Overview](https://github.com/sanderfabian/MiseEnPlace/blob/main/Images/Recipe3.png)

## Add your Spoonacular APIkey
BaseViewModel
```C#
 public class SelectionPageViewModel : BaseViewModel
    {
        private const string apiKey = "700d5c31506842aaxxxxxxxxxxxx"; //ADD SPOONACULAR API KEY HERE
```
ResultsPageViewModel
```C#
public  class ResultPageViewModel : BaseViewModel // experiment on MVVM, creating a individual baseviewmodel to notify when property changes
    {
        private const string apiKey = "700d5c31506842aaxxxxxxxxxxxx"; //ADD SPOONACULAR API KEY HERE
```
  
