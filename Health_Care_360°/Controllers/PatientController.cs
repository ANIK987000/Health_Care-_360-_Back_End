using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Health_Care_360_.Controllers
{
    public class PatientController : ApiController
    {

        [HttpPost]
        [Route("api/Patient/Register")]
        public HttpResponseMessage Register(PatientDTO patient)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = PatientService.Add(patient);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch(Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, ex);
            }

        }
        


    }
}
