using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SDAssignment
{
    public class TimeTableDecorator:TimeTable
    {
        protected TimeTable timeTable;
        public TimeTableDecorator(TimeTable tb):base(tb)
        {
            this.timeTable = tb;
        }
    }
}
