using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using Sunshine.Models;
using System.Net.Http.Headers;
using System.Collections.Generic;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;

namespace Sunshine.Controllers
{
    [RoutePrefix("api/user")]
    public class UserController : ApiController
    {
        private VietnamSunshineEntities sunshineEntities = new VietnamSunshineEntities();

        
        [HttpGet]
        [ResponseType(typeof(List<City>))]
        [Route("city")]
        public IHttpActionResult getCities()
        {
            try
            {
                var result = new HttpResponseMessage(HttpStatusCode.OK);

                return Ok(sunshineEntities.Cities.ToList());
              
            }
            catch
            {
                return Ok(HttpStatusCode.BadRequest);
            }
        }
        [HttpGet]
        [ResponseType(typeof(List<District>))]
        [Route("city/{id}")]
        public IHttpActionResult getDistricts(int id)
        {
            try
            {
                var result = new HttpResponseMessage(HttpStatusCode.OK);

                return Ok(sunshineEntities.Districts.Where(p => p.IdCity == id).ToList());

            }
            catch
            {
                return Ok(HttpStatusCode.BadRequest);
            }
        }
        [HttpGet]
        [ResponseType(typeof(List<Ward>))]
        [Route("district/{id}")]
        public IHttpActionResult getWards(int id)
        {
            try
            {
                var result = new HttpResponseMessage(HttpStatusCode.OK);

                return Ok(sunshineEntities.Wards.Where(p => p.IdDistrict == id).ToList());

            }
            catch
            {
                return Ok(HttpStatusCode.BadRequest);
            }
        }
    }
}
