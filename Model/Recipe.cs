using System;
using System.Collections.Generic;
using System.Text;

namespace MenuApp
{
    public class Recipe
    {
        public int id { get; set; }
        public string title { get; set; }
        public string steps { get; set; }
        public string image { get; set; }
        public List<Ingredient> ingredients = new List<Ingredient>();

        public override string ToString()
        {
            return $"{title} : \n " +
                "\tIngredients :\n" +
                $"{String.Join("", ingredients)}" +
                $"Steps :\n{steps}";
        }
    }

    public class Ingredient
    {
        public int id { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string quantity { get; set; }

        public override string ToString()
        {
            return $"\t\t{name} - {quantity}\n";
        }
    }





}
