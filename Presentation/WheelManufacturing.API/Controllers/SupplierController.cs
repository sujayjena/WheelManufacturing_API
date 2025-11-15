using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WheelManufacturing.Application.Enums;
using WheelManufacturing.Application.Helpers;
using WheelManufacturing.Application.Interfaces;
using WheelManufacturing.Application.Models;

namespace WheelManufacturing.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SupplierController : CustomBaseController
    {
        private ResponseModel _response;
        private readonly ISupplierRepository _supplierRepository;
        private readonly IContactDetailsRepository _contactDetailsRepository;
        private readonly IBillingDetailsRepository _billingDetailsRepository;
        private readonly IShippingDetailsRepository _shippingDetailsRepository;
        private readonly ILoginCredentialsRepository _loginCredentialsRepository;
        private IFileManager _fileManager;

        public SupplierController(ISupplierRepository supplierRepository,
            IContactDetailsRepository contactDetailsRepository,
            IBillingDetailsRepository billingDetailsRepository,
            IShippingDetailsRepository shippingDetailsRepository,
            ILoginCredentialsRepository loginCredentialsRepository,
            IFileManager fileManager)
        {
            _supplierRepository = supplierRepository;
            _contactDetailsRepository = contactDetailsRepository;
            _billingDetailsRepository = billingDetailsRepository;
            _shippingDetailsRepository = shippingDetailsRepository;
            _loginCredentialsRepository = loginCredentialsRepository;
            _fileManager = fileManager;

            _response = new ResponseModel();
            _response.IsSuccess = true;
        }

        [Route("[action]")]
        [HttpPost]
        //[AllowAnonymous]
        public async Task<ResponseModel> SaveSupplier(Supplier_Request parameters)
        {
            //Pan Upload
            if (parameters! != null && !string.IsNullOrWhiteSpace(parameters.Pan_Base64))
            {
                var vUploadFile = _fileManager.UploadDocumentsBase64ToFile(parameters.Pan_Base64, "\\Uploads\\Supplier\\", parameters.PanOriginalFileName);

                if (!string.IsNullOrWhiteSpace(vUploadFile))
                {
                    parameters.PanFileName = vUploadFile;
                }
            }

            bool bIsSupplierDeleted = false;
            int result = await _supplierRepository.SaveSupplier(parameters);

            if (result == (int)SaveOperationEnums.NoRecordExists)
            {
                _response.Message = "No record exists";
            }
            else if (result == (int)SaveOperationEnums.ReocrdExists)
            {
                _response.Message = "Record is already exists";
            }
            else if (result == (int)SaveOperationEnums.NoResult)
            {
                _response.Message = "Something went wrong, please try again";
            }
            else if (result == -3)
            {
                _response.Message = "Mobile Number is exists";
            }
            else if (result == -4)
            {
                _response.Message = "Email is exists";
            }
            else
            {
                _response.Message = "Record details saved sucessfully";

                if (result > 0)
                {
                    string strContactErrorMsg = "";
                    string strLoginErrorMsg = "";

                    // Add data into Contact details
                    foreach (var items in parameters.ContactDetailsList)
                    {
                        var vContactDetails = new ContactDetails_Request()
                        {
                            Id = items.Id,
                            RefId = result,
                            RefType = "Supplier",
                            ContactPerson = items.ContactPerson,
                            MobileNo = items.MobileNo,
                            EmailId = items.EmailId,
                            IsActive = items.IsActive,
                        };

                        int resultContactDetails = await _contactDetailsRepository.SaveContactDetails(vContactDetails);

                        if (resultContactDetails == (int)SaveOperationEnums.NoRecordExists)
                        {
                            strContactErrorMsg = "No record exists in Contact detail";
                        }
                        else if (resultContactDetails == (int)SaveOperationEnums.ReocrdExists)
                        {
                            strContactErrorMsg = "Record is already exists in Contact detail";
                        }
                        else if (resultContactDetails == (int)SaveOperationEnums.NoResult)
                        {
                            strContactErrorMsg = "Something went wrong in Contact detail, please try again";
                        }
                        else if (resultContactDetails == -3)
                        {
                            strContactErrorMsg = "Mobile Number is exists in Contact detail";
                        }

                        if (!string.IsNullOrWhiteSpace(strContactErrorMsg))
                        {
                            _response.Message = strContactErrorMsg;

                            int resultDeleteSupplier = await _supplierRepository.DeleteSupplier(result);
                            if (resultDeleteSupplier > 0)
                            {
                                bIsSupplierDeleted = true;
                            }
                        }
                    }

                    if (bIsSupplierDeleted == false)
                    {
                        // Add data into Billing details
                        foreach (var items in parameters.BillingDetailsList)
                        {
                            //GST Upload
                            if (!string.IsNullOrWhiteSpace(items.GST_Base64))
                            {
                                var vUploadFile = _fileManager.UploadDocumentsBase64ToFile(items.GST_Base64, "\\Uploads\\BillingDetails\\", items.GSTOriginalFileName);

                                if (!string.IsNullOrWhiteSpace(vUploadFile))
                                {
                                    items.GSTFileName = vUploadFile;
                                }
                            }

                            var vBillingDetails = new BillingDetails_Request()
                            {
                                Id = items.Id,
                                RefId = result,
                                RefType = "Supplier",
                                IsNational_Or_International = items.IsNational_Or_International,
                                AddressLine1 = items.AddressLine1,
                                CountryId = items.CountryId,
                                StateId = items.StateId,
                                DistrictId = items.DistrictId,
                                CityId = items.CityId,
                                PinCode = items.PinCode,
                                IsGST = items.IsGST,
                                GSTNumber = items.GSTNumber,
                                GSTOriginalFileName = items.GSTOriginalFileName,
                                GSTFileName = items.GSTFileName,
                                IsActive = items.IsActive,
                            };

                            int resultBillingDetails = await _billingDetailsRepository.SaveBillingDetails(vBillingDetails);
                        }

                        // Add data into Shipping details
                        foreach (var items in parameters.ShippingDetailsList)
                        {
                            var vShippingDetails = new ShippingDetails_Request()
                            {
                                Id = items.Id,
                                RefId = result,
                                RefType = "Supplier",
                                IsNational_Or_International = items.IsNational_Or_International,
                                AddressLine1 = items.AddressLine1,
                                CountryId = items.CountryId,
                                StateId = items.StateId,
                                DistrictId = items.DistrictId,
                                CityId = items.CityId,
                                PinCode = items.PinCode,
                                IsActive = items.IsActive,
                            };

                            int resultShippingDetails = await _shippingDetailsRepository.SaveShippingDetails(vShippingDetails);
                        }
                    }
                }
            }

            if (bIsSupplierDeleted == true)
            {
                _response.Id = 0;
            }

            return _response;
        }


        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetSupplierList(SupplierSearch_Request parameters)
        {
            IEnumerable<Supplier_Response> lstSuppliers = await _supplierRepository.GetSupplierList(parameters);
            _response.Data = lstSuppliers.ToList();
            _response.Total = parameters.Total;
            return _response;
        }

        [Route("[action]")]
        [HttpPost]
        public async Task<ResponseModel> GetSupplierById(long Id)
        {
            if (Id <= 0)
            {
                _response.Message = "Id is required";
            }
            else
            {
                var vResultObj = await _supplierRepository.GetSupplierById(Id);

                _response.Data = vResultObj;
            }
            return _response;
        }
    }
}
