
using BrightAcademie.Business.Abstract;
using BrightAcademie.Business.Concrete;
using BrightAcademie.Data.Abstract;
using BrightAcademie.Data.Concrete.EfCore.Contexts;
using BrightAcademie.Data.Concrete.EfCore.Repository;
using BrightAcademie.Entity.Concrete;
using Microsoft.AspNetCore.Cors.Infrastructure;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Data;
using BrightAcademie.Data.Concrete.EfCore.Repositories;
using BrightAcademie.Shared.DTOs;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddRouting(r => r.LowercaseUrls = true);
builder.Services.AddDbContext<BrightAcademieContext>(options => options.UseSqlite(builder.Configuration.GetConnectionString("SqliteConnection")));

builder.Services.AddIdentity<Trainee, Role>()
    .AddEntityFrameworkStores<BrightAcademieContext>()
    .AddDefaultTokenProviders();

builder.Services.AddAuthentication();
builder.Services.Configure<IdentityOptions>(options =>
{
    options.Password.RequireDigit = true;//�ifre i�inde say�sal de�er olmal� m�?
    options.Password.RequireLowercase = true;//�ifre i�inde k���k harf olmal� m�?
    options.Password.RequireUppercase = true;//�ifre i�inde b�y�k harf olmal� m�?
    options.Password.RequiredLength = 6;//�ifrenin uzunlu�u en az ka� karakter olmal�?
    options.Password.RequireNonAlphanumeric = true;//�ifre i�inde �zel karakter olmal� m�?

    options.Lockout.MaxFailedAccessAttempts = 3; //�st �ste izin verilecek hatal� giri� say�s�
    options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);//�st �ste izin verilen kez hatal� giri� yapmaya �al���lan hesap hangi s�reyle kilitlenecek?

    options.User.RequireUniqueEmail = true;//Sistemden daha �nce kay�tl� olmayan bir mail adresi kullan�lmak zorunda olsun mu?

    options.SignIn.RequireConfirmedEmail = false;//Kay�t olunurken email onay� istensin mi?
    options.SignIn.RequireConfirmedPhoneNumber = false; //Kay�t olunurken telefon onay� istensin mi?


});


builder.Services.AddScoped<ITraineeService, TraineeManager>();
builder.Services.AddScoped<ICourseService, CourseManager>();
builder.Services.AddScoped<ICategoryService, CategoryManager>();
builder.Services.AddScoped<ITrainerService, TrainerManager>();

builder.Services.AddScoped<ITraineeRepository, EfCoreTraineeRepository>();
builder.Services.AddScoped<ICourseRepository, EfCoreCourseRepository>();
builder.Services.AddScoped<ICategoryRepository, EfCoreCategoryRepository>();
builder.Services.AddScoped<ITrainerRepository, EfCoreTrainerRepository>();

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


builder.Services.AddCors(options =>
{
    options.AddPolicy(
        name: "_allowAllPolicy",
        policy =>
        {
            policy
            .AllowAnyOrigin()
            .AllowAnyMethod()
            .AllowAnyHeader();
        }
    );
});

var app = builder.Build();
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();
app.UseCors("_allowAllPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();
app.Run();


