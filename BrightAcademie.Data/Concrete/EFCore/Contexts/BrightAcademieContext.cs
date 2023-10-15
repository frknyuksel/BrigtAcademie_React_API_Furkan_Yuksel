using BrightAcademie.Data.Concrete.EfCore.Configs;
using BrightAcademie.Data.Concrete.EfCore.Extensions;
using BrightAcademie.Entity.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Data.Concrete.EfCore.Contexts
{
    public class BrightAcademieContext :IdentityDbContext<Trainee>
    {
        public BrightAcademieContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseCategory> CoursesCategories { get; set; }
        public DbSet<CourseTrainee> CourseTrainees { get; set; }
        public DbSet<Setting> Settings { get; set; }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.SeedData();
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CourseConfig).Assembly);
            base.OnModelCreating(modelBuilder); 
        }

    }
}

