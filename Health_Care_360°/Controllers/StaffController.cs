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
    public class StaffController : ApiController
    {
        [HttpPost]
        [Route("api/Staff/AddMedicine")]
        public HttpResponseMessage AddMedicine(MedicineDTO medicine)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var data = MedicineService.Add(medicine);
                    return Request.CreateResponse(HttpStatusCode.OK, data);
                }
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateResponse(HttpStatusCode.NoContent,ex);
            }
        }
    }
}
