using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi_ass.Models;
namespace WebApi_ass.Controllers
{
    public class CountryController : ApiController
    {

        public List<Country> c = new List<Country>();
        public CountryController()
        {
            c.Add(new Country { Id = 1, Countryname = "Pakistan", Capital = "Islam" });
            c.Add(new Country { Id = 2, Countryname = "Thailand", Capital = "Bankok" });
            c.Add(new Country { Id = 3, Countryname = "Japan", Capital = "Tokyo" });
        }
        [HttpGet]
        public List<Country> GetallCountries()
        {
            return c;
        }
        [HttpPost]
        public List<Country> Create([FromBody] Country country)
        {
            c.Add(country);
            return c;
        }
        [HttpPut]
        public List<Country> Update(int id, [FromBody] Country country)
        {
            var CountryList = c.Find(c => c.Id == id);
            if (CountryList == null)
            {
            }
            CountryList.Countryname = country.Countryname;
            CountryList.Capital = country.Capital;
            return c;
        }
        [HttpDelete]
        public List<Country> Delete(int id)
        {
            var country_list = c.Find(c => c.Id == id);
            if (country_list == null)
            {
            }
            c.Remove(country_list);
            return c;
        }
    }
}