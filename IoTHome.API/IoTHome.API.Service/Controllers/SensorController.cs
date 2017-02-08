using IoTHome.API.Data;
using IoTHome.API.Data.IoTDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace IoTHome.API.Service.Controllers
{
    [RoutePrefix("api/sensors")]
    public class SensorController : ApiController
    {
        [HttpGet]
        [Route("get-sensor-recordings")]
        public HttpResponseMessage GetAllBatches()
        {
            ApplicationLogic logic = new ApplicationLogic();

            List<SensorRecordingDAO> sensorRecordings = logic.GetSensorRecordsProcessed();
            return Request.CreateResponse(HttpStatusCode.OK, sensorRecordings, "application/json");
        }
    }
}
