﻿using BrightAcademie.Entity.Concrete;
using BrightAcademie.Shared.DTOs;
using BrightAcademie.Shared.ResponseDTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrightAcademie.Business.Abstract
{
    public interface ITrainerService
    {
        #region Generic
        Task<Response<TrainerDto>> GetByIdAsync(int id);
        Task<Response<List<TrainerDto>>> GetAllAsync();
        Task<Response<TrainerDto>> CreateAsync(TrainerCreateDto trainerCreateDto);
        Task<Response<NoContent>> UpdateAsync(TrainerUpdateDto trainerUpdateDto);
        Task<Response<NoContent>> DeleteAsync(int id);
        #endregion

        Task<List<Trainer>> GetAllTrainersAsync(bool isDeleted, bool? isActive = null);
        Task CreateWithUrl(Trainer trainer);
    }
}
