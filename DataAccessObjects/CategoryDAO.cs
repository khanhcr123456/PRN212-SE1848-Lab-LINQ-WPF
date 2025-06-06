using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;

namespace DataAccessLayer;

public class CategoryDAO
{
    public static List<Category> GetCategories()
    {
        var beverages = new Category { CategoryID = 1, CategoryName = "Beverages" };
        var condiments = new Category { CategoryID = 2, CategoryName = "Condiments" };
        var confections = new Category { CategoryID = 3, CategoryName = "Confections" };
        var dairy = new Category { CategoryID = 4, CategoryName = "Dairy Products" };
        var grains = new Category { CategoryID = 5, CategoryName = "Grains/Cereals" };
        var meat = new Category { CategoryID = 6, CategoryName = "Meat/Poultry" };
        var produce = new Category { CategoryID = 7, CategoryName = "Produce" };
        var seafood = new Category { CategoryID = 8, CategoryName = "Seafood" };

        var listCategories = new List<Category>();
        try
        {
            listCategories.Add(beverages);
            listCategories.Add(condiments);
            listCategories.Add(confections);
            listCategories.Add(dairy);
            listCategories.Add(grains);
            listCategories.Add(meat);
            listCategories.Add(produce);
            listCategories.Add(seafood);
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);
        }

        return listCategories;
    }
}
