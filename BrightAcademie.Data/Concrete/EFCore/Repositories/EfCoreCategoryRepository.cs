﻿using BrightAcademie.Data.Concrete.EfCore.Repositories;
using BrightAcademie.Data.Abstract;
using BrightAcademie.Data.Concrete.EfCore.Contexts;
using BrightAcademie.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Data.Concrete.EfCore.Repository
{
    public class EfCoreCategoryRepository : EfCoreGenericRepository<Category>, ICategoryRepository
    {
        public EfCoreCategoryRepository(BrightAcademieContext _context) : base(_context)
        {
        }
        private BrightAcademieContext Context { get { return _dbContext as BrightAcademieContext; } }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context.Categories.AnyAsync(x => x.Id == id);
        }

        public async Task<List<Category>> GetAllCategoriesAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Categories
                .Where(c => c.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(c => c.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
