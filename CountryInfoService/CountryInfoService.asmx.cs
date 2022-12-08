using System.Collections.Generic;
using System.Web.Services;

namespace CountryInfoService
{
    /// <summary>
    /// Summary description for CountryInfoService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class CountryInfoService : System.Web.Services.WebService
    {
        [WebMethod]
        public List<CountryByNameAndCode> GetAllCountryByNameAndCode()
        {
            var countries = new List<CountryByNameAndCode>()
            {
                new CountryByNameAndCode() { Code = "AD", Name = "Andorra" },
                new CountryByNameAndCode() { Code = "AE", Name = "United Arab Emirates" },
                new CountryByNameAndCode() { Code = "AF", Name = "Afghanistan" },
                new CountryByNameAndCode() { Code = "AG", Name = "Antigua & Barbuda" }
                //TODO - Add more here
            };

            return countries;
        }
    }

    public class CountryByNameAndCode
    {
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
