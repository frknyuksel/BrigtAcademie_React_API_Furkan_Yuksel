﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Shared.DTOs
{
    public class TrainerUpdateDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int BirthOfYear { get; set; }
        public string Education { get; set; }
        public string Experience { get; set; }
        public string Url { get; set; }
        public string About { get; set; }
        public string PhotoUrl { get; set; }
        public string Field { get; set; }
        public decimal Evaluation { get; set; }
    }
}
