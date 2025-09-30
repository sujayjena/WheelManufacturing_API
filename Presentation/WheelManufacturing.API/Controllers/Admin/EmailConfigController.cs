﻿using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;
using WheelManufacturing.Persistence.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WheelManufacturing.API.Controllers.Admin
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmailConfigController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly IEmailConfigRepository _emailConfigRepository;

        public EmailConfigController(IEmailConfigRepository EmailConfigRepository)
        {
            _emailConfigRepository = EmailConfigRepository;
            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveEmailConfig(EmailConfig_Request parameters)
        {
            int result = await _emailConfigRepository.SaveEmailConfig(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else
            {
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetEmailConfigList(EmailConfig_Search parameters)
        {
            IEnumerable<EmailConfig_Response> lstRoles = await _emailConfigRepository.GetEmailConfigList(parameters);
            _response.Data = lstRoles.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetEmailConfigById(int Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _emailConfigRepository.GetEmailConfigById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> SaveEmailNotification(EmailNotification_Request parameters)
        {
            int result = await _emailConfigRepository.SaveEmailNotification(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else
            {
                _response.Message = "Record details saved sucessfully";
            }

            _response.Id = result;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetEmailNotificationById(int Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _emailConfigRepository.GetEmailNotificationById(Id);
                _response.Data = vResultObj;
            }
            return _response;
        }

    }
}
