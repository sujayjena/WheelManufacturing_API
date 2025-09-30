using WheelManufacturing.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WheelManufacturing.Application.Models
{
    public class TerritoryModel
    {
    }

    #region Country

    public class Country_Request : BaseEntity
    {
        public string? CountryName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Country_Response : BaseResponseEntity
    {
        public string? CountryName { get; set; }
        public bool? IsActive { get; set; }
    }

    #endregion

    #region State

    public class State_Request : BaseEntity
    {
        public string? StateName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class State_Response : BaseResponseEntity
    {
        public string? StateName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class StateDataValidationErrors
    {
        public string StateName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedState
    {
        public string StateName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion

    #region District

    public class District_Request : BaseEntity
    {
        public string? DistrictName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class District_Response : BaseResponseEntity
    {
        public string? DistrictName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class DistrictDataValidationErrors
    {
        public string DistrictName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedDistrict
    {
        public string DistrictName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion

    #region City

    public class City_Request : BaseEntity
    {
        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class City_Response : BaseResponseEntity
    {
        public string? CityName { get; set; }

        public bool? IsActive { get; set; }
    }

    public class CityDataValidationErrors
    {
        public string CityName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedCity
    {
        public string CityName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion

    #region Territories

    public class Territories_Request : BaseEntity
    {
        [DefaultValue(1)]
        public int? IsNational_Or_International { get; set; }
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? DistrictId { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Territories_Response : BaseResponseEntity
    {
        public int? IsNational_Or_International { get; set; }
        public int? CountryId { get; set; }
        public string? CountryName { get; set; }
        public int? StateId { get; set; }
        public string? StateName { get; set; }
        public int? DistrictId { get; set; }
        public string? DistrictName { get; set; }
        public bool? IsActive { get; set; }
    }

    public class Territories_Country_State_Dist_Search
    {
        public int? CountryId { get; set; }
        public int? StateId { get; set; }
        public int? DistrictId { get; set; }
    }

    public class Territories_Country_State_Dist_Response
    {
        public int? Id { get; set; }
        public string? Value { get; set; }
        public string? Text { get; set; }
    }

    public class TerritoriesDataValidationErrors
    {
        public string IsNational_Or_International { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string IsActive { get; set; }
        public string ValidationMessage { get; set; }
    }
    public class ImportedTerritories
    {
        public string IsNational_Or_International { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public string DistrictName { get; set; }
        public string IsActive { get; set; }
    }

    #endregion
}
