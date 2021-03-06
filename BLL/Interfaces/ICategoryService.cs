﻿using DAL;
using DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
   public interface ICategoryService
    {
        IEnumerable<CategoriesDTO> GetAllCategories();
        CategoriesDTO GetProductsWithCategories(string id);
    }
}
