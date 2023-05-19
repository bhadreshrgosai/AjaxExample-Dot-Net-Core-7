using AjaxExample_Dot_Net_Core_7.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AjaxExample_Dot_Net_Core_7.Controllers
{
    public class HomeController : Controller
    {
        List<CountryModel> _countries;
        List<StateModel> _states;
        public HomeController()
        {
            _countries = new List<CountryModel>()
            {
                new CountryModel() {

                    CountryName = "IND",CountryId =1
                },
                new CountryModel() {

                    CountryName = "USA",CountryId =2
                },
                new CountryModel() {

                    CountryName = "UK",CountryId =3
                }
            };

            _states = new List<StateModel>() {

                new StateModel()
                {
                    CountryId = 1,
                    StateId = 1,
                    StateName = "AAA--1"
                },
                new StateModel()
                {
                    CountryId = 1,
                    StateId = 2,
                    StateName = "AAA--$"
                },
                new StateModel()
                {
                    CountryId = 2,
                    StateId = 3,
                    StateName = "BBB--1"
                },
                new StateModel()
                {
                    CountryId = 3,
                    StateId = 4,
                    StateName = "CCC--3"
                },

            };
        }
        public IActionResult Index()
        {
            return View(_countries);
        }
        public JsonResult GetDtateByCountryId(int cid)
        {
            var states = _states.Where(a=>a.CountryId == cid);
            return new JsonResult(states);
        }
    }
}