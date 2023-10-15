using BrightAcademie.Data.Concrete.EfCore.Repositories;
using BrightAcademie.Data.Abstract;
using BrightAcademie.Data.Concrete.EfCore.Contexts;
using BrightAcademie.Entity.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Data.Concrete.EFCore.Repositories
{
    public class EfCoreSettingRepository : EfCoreGenericRepository<Setting>, ISettingRepository
    {
        public EfCoreSettingRepository(BrightAcademieContext _context) : base(_context)
        {
        }
        private BrightAcademieContext Context
        {
            get { return _dbContext as BrightAcademieContext; }
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context
                .Settings
                .AnyAsync(x => x.Id == id);
        }

        public async Task<List<Setting>> GetAllSettings(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Settings
                .Where(a => a.IsDeleted == isDeleted)
                .AsQueryable();
            if (isActive != null)
            {
                result = result
                    .Where(a => a.IsActive == isActive)
                    .AsQueryable();
            }
            return await result.ToListAsync();
        }
    }
}
