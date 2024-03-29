﻿using BrightAcademie.Shared.DTOs;
using BrightAcademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Business.Abstract
{
    public interface ICategoryService
    {
        #region Generic
        Task<Response<CategoryDto>> GetByIdAsync(int id);
        Task<Response<List<CategoryDto>>> GetAllAsync();
        Task<Response<CategoryDto>> CreateAsync(CategoryCreateDto categoryCreateDto);
        Task<Response<NoContent>> UpdateAsync(CategoryUpdateDto categoryUpdateDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        #endregion
    }
}
