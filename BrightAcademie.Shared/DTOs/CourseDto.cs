﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Shared.DTOs
{
    public class CourseDto
    {   
        public int Id { get; set; }
        public string Name { get; set; }
        public string TotalTime { get; set; }
        public string Time { get; set; }
        public decimal Price {  get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
        public bool IsHome { get; set; }
        public string Description { get; set; }
        public string CourseLevel { get; set; }
        public string Location { get; set; }
        public string Earnings { get; set; }
        public string Statues { get; set; }
        public decimal Evaluation { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }
        public string TrainerName { get; set; }
        public TrainerDto Trainer { get; set; }
        public CategoryDto Categories { get; set; }
        public string TraineeName { get; set; }
        public List<TraineeDto> Trainees { get; set; }
    }
}
