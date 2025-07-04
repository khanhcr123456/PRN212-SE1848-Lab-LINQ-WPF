﻿using BusinessObjects;
using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        public List<BusinessObjects.Category> GetCategories() => CategoryDAO.GetCategories();

        List<BusinessObjects.Category> ICategoryRepository.GetCategories()
        {
            throw new NotImplementedException();
        }
    }
}
