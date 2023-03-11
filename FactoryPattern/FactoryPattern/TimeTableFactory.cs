using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SDAssignment
{
    public class TimeTableFactory
    {
        public TimeTable GetTimeTableObject(string type, List<KeyValueDTO> lstTimeTable)
        {
            if (type == "Msc. Artificial Intelligence")
            {
                return new MSCAI(new TimeTable(lstTimeTable));
            }
            else if (type == "Msc. Software Engineering")
            {
                return new MSCSoftwareEngineering(new TimeTable(lstTimeTable));
            }
            else if (type == "Msc. Cloud Computing")
            {
                return new MSCCloudComputing(new TimeTable(lstTimeTable));
            }
            else
            {
                return new TimeTable(lstTimeTable);
            }
        }
    }
}
