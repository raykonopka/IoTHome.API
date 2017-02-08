using IoTHome.API.Data.IoTDataService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IoTHome.API.Data
{
    public class DataClient
    {
        private DataServiceClient data = new DataServiceClient();

        public List<SensorRecordingDAO> GetAllSensorRecords()
        {
            return data.GetAllSensorHistories().ToList();
        }
    }
}
