﻿using System.ComponentModel;
using BrightAcademie.Entity.Concrete;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BrightAcademie.Shared.DTOs;

public class CourseCreateAdminDto
{
    public string Name { get; set; }
    public string TotalTime { get; set; }
    public string Time { get; set; }
    // public DateTime Start { get; set; }
    // public DateTime End { get; set; }
    public bool IsHome { get; set; }
    public decimal Price {  get; set; }
    public string Location { get; set; }
    public string Description { get; set; }
    public string CourseLevel { get; set; }
    public string Earnings { get; set; }
    public string ImageUrl { get; set; }

    [DisplayName("Eğitmen")]
    public List<TrainerCreateDto> TrainerList { get; set; }

    [DisplayName("Kategoriler")]
    public List<CategoryCreateDto> CategoryList { get; set; }

}