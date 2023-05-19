using AjaxExample_Dot_Net_Core_7.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AjaxExample_Dot_Net_Core_7.Controllers
{
    public class CountryController : Controller
    {
        List<CountryModel> _countries;
        List<StateModel> _states;
        public CountryController()
        {
            _countries = new List<CountryModel>()
            {
                new CountryModel() {

                    CountryName = "IND",CountryId =1
                },
                new CountryModel() {

                    CountryName = "USA",CountryId =2, IsActive = true
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
        // GET: CountryController
        public ActionResult Index()
        {
            return View(_countries);
        }

        // GET: CountryController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        [HttpPost]
        public JsonResult ToggelActiveCountry(IsActiveViewModel data)
        {
            var obj = new Dictionary<string, string>();
            //CountryModel country = dbContext.CountryModel.find(data.id);
            //if (country == null)
            //{
            //    obj["error"] = "Country Not Found!";

            //    return new JsonResult(obj);
            //}
            try
            {
                //code: country isactive field update
                obj["success"] = "Done";
            }
            catch (Exception ex)
            {

                obj["error"] = ex.Message;
            }

            return new JsonResult(obj);
        }
    }
}
