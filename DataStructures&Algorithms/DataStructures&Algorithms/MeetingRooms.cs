using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures_Algorithms
{
    
    internal class MeetingRooms
    {
        public class Interval
        {
            public int start;
            public int end;
            public Interval() { start = 0; end = 0; }
            public Interval(int s, int e) { start = s; end = e; }
        }

        public bool CanAttendMeetings(Interval[] intervals)
        {
            Array.Sort(intervals, (a, b) => a.start.CompareTo(b.start));
            for (int i = 1; i < intervals.Length; i++)
            {
                if (intervals[i].start < intervals[i - 1].end)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
