using ValidationAssignment.BusinessLogic;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ValidationAssignment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AddressDataController : ControllerBase
    {
        PopulateAddressData populateAddressData = new PopulateAddressData();

        [HttpGet]
        [Route("Countries")]
        public List<Countries> CountryDetails()
        {
            return populateAddressData.GetCountries();
        }

        [HttpGet]
        [Route("Cities")]
        public List<Cities> CityDetails(int countryID)
        {
            return populateAddressData.GetCities(countryID);
        }
    }
}
