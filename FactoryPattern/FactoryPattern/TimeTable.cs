using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAssignment
{
    public class TimeTable
    {
        private List<KeyValueDTO> TimeTables { get; set; } = new List<KeyValueDTO>();

        public TimeTable(TimeTable timeTable)
        {
            this.TimeTables = timeTable.TimeTables;
        }

        public TimeTable(List<KeyValueDTO> lstTimeTable)
        {
            this.TimeTables = lstTimeTable;
        }

        public List<KeyValueDTO> GetTimTable()
        {
            return this.TimeTables;
        }

        public virtual List<KeyValueDTO> GetValues()
        {
            return this.TimeTables;
        }
    }
}
