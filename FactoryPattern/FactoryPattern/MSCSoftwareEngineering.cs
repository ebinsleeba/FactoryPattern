using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAssignment
{
    public class MSCSoftwareEngineering : TimeTableDecorator
    {
        public MSCSoftwareEngineering(TimeTable timeTable) : base(timeTable)
        {
        }

        public override List<KeyValueDTO> GetValues()
        {
            return timeTable.GetTimTable().Where(x => x.Key == "mscsoft").ToList();
        }
    }
}
