# Mise En Place
![Overview](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/e0b92553-a2c2-41e7-82a4-05b00cf0c9f5)

## Description
Mise En Place is a .Net MAUI mobile application that uses SpoonacularAPI to retrieve recipes based on the Ingredients available to the users.
## Images
### Startup & Ingredient Selection
![Startup & Ingredient Selection](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/fa22c20e-bef9-4187-b754-cd77da073167)<br>


Choose from a variety of options catalogued into distinct categories. <br>

---

### Select & Review


![Frame 88](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/0ab539d2-b8eb-4351-9472-d53de0aa5d91)<br>


Review your selection and send it!<br>


![quick (1)](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/cd463dd1-c7ef-46a8-b8ca-4f4d6b0805cd)<br>


A quick Navigation option to select category pages.<br>

---

### Getting your Recipes
Based on your Selected tags Mise En Place will pull recipes from Spoonacular to fit your requirements

![swipe](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/8fe8fdd8-bb08-45ea-b29c-e3e585122fea)<br>


After loading, your results will be presented.
Swipe through your available options!

---

### Reading your Recipes
Recipes are displayed in detail:<br>

![Scroll](https://github.com/sanderfabian/MiseEnPlace/assets/145095620/5d319aa5-f18e-46f1-8530-dcb77e959442)



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
  
