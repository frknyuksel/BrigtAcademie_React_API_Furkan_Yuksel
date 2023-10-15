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

namespace BrightAcademie.Data.Concrete.EfCore.Repository
{
    public class EfCoreTrainerRepository : EfCoreGenericRepository<Trainer>, ITrainerRepository
    {
        public EfCoreTrainerRepository(BrightAcademieContext _context) : base(_context)
        {
        }
        private BrightAcademieContext Context 
        {
            get { return _dbContext as BrightAcademieContext; }
        
        }

        public async Task<bool> AnyAsync(int id)
        {
            return await Context.Trainers.AnyAsync(x => x.Id == id);
        }

        public async Task CreateWithUrl(Trainer trainer)
        {
            await Context.Trainers.AddAsync(trainer);
            await Context.SaveChangesAsync();
            trainer.Url = trainer.Url + "-" + trainer.Id;
            await Context.SaveChangesAsync();
        }

        public async Task<List<Trainer>> GetAllTrainersAsync(bool isDeleted, bool? isActive = null)
        {
            var result = Context
                .Trainers
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
