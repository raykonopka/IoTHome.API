using IoTHome.API.Data.IoTDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTHome.API.Data
{
    public class ApplicationLogic
    {
        private DataClient dataClient = new DataClient();
        public List<SensorRecordingDAO> GetSensorRecordsProcessed()
        {
            return dataClient.GetAllSensorRecords();
        }

    }
}
