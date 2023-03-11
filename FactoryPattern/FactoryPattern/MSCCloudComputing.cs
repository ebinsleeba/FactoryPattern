using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAssignment
{
    public class MSCCloudComputing : TimeTableDecorator
    {
        public MSCCloudComputing(TimeTable tb) : base(tb)
        {
        }

        public override List<KeyValueDTO> GetValues()
        {
            return timeTable.GetTimTable().Where(x => x.Key == "msccloud").ToList();
        }
    }
}
