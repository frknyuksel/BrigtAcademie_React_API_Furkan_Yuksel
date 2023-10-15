using BrightAcademie.Data.Abstract;
using BrightAcademie.Data.Concrete.EfCore.Contexts;
using BrightAcademie.Entity.Concrete;
using BrightAcademie.Shared.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Data.Concrete.EfCore.Repositories
{
    public class EfCoreCartRepository : EfCoreGenericRepository<Cart>, ICartRepository
    {
        public EfCoreCartRepository(BrightAcademieContext _appContext) : base(_appContext)
        {

        }
        BrightAcademieContext AppContext
        {
            get { return _dbContext as BrightAcademieContext; }
        }

        public async Task AddToCartAsync(string userId, int courseId, int quantity)
        {
            var cart = await GetCartByUserId(userId);
            if (cart != null)
            {
                var index = cart.CartItems.FindIndex(ci => ci.CourseId == courseId);
                if (index < 0)//Kitap daha önceden sepete eklenmemişse
                {
                    cart.CartItems.Add(new CartItem
                    {
                        CourseId = courseId,
                        CartId = cart.Id,
                        Quantity = quantity
                    });
                }
                else //Eğer kitap daha önceden sepete eklenmişse -- adedi arttıracağız
                {
                    cart.CartItems[index].Quantity += quantity;
                }

                AppContext.Carts.Update(cart);
                await AppContext.SaveChangesAsync();
            }
        }


        public async Task<Cart> GetCartByUserId(string userId)
        {
            var result = await AppContext
                .Carts
                .Where(c => c.UserId == userId)
                .Include(c => c.CartItems)
                .ThenInclude(ci => ci.Course)
                .FirstOrDefaultAsync();
            return result;
        }
    }
}
