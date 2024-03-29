﻿using BrightAcademie.Entity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Shared.DTOs
{
    public class OrderItemDto
    {

        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public int CourseId { get; set; }
        public Course Course { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

    }

}
