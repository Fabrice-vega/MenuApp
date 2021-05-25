using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
    public class MenuAppController
    {
        public void Populate()
        {
            var ingredient1 = new Ingredient 
            { 
                name = "Carrot",
                quantity = "400gr"
            };
            var ingredient2 = new Ingredient
            {
                name = "Ground beef",
                quantity = "250gr"
            };
            var ingredient3 = new Ingredient
            {
                name = "Potato",
                quantity = "500gr"
            };
            var ingredient4 = new Ingredient
            {
                name = "Fries",
                quantity = "150gr"
            };
            var ingredient5 = new Ingredient
            {
                name = "Angus steak",
                quantity = "250gr"
            };
            var ingredient6 = new Ingredient
            {
                name = "Salad",
                quantity = "50gr"
            };

            var recipe1 = new Recipe
            {
                title = "Carrot ratatouille",
                steps = "blabla",
                ingredients = {ingredient1, ingredient2, ingredient3}
            };
            var recipe2 = new Recipe
            {
                title = "Steak and fries",
                steps = "blabla",
                ingredients = { ingredient4, ingredient5, ingredient6 }
            };
            Menu(recipe1);
            Menu(recipe2);
        }

        public void Menu(Recipe recipe)
        {
            Console.WriteLine(recipe);
            Console.ReadKey();

        }
    }
}
