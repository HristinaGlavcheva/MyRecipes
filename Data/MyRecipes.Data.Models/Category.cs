﻿namespace MyRecipes.Data.Models
{
    using System.Collections.Generic;

    using MyRecipes.Data.Common.Models;

    public class Category : BaseDeletableModel<int>
    {
        public Category()
        {
            this.Recepies = new HashSet<Recipe>();
        }

        public string Name { get; set; }

        public ICollection<Recipe> Recepies { get; set; }
    }
}
