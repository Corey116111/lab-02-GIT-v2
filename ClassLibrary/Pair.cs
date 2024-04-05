using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit 7 вариант
    /// </summary>
    public class Pair
    {
        private readonly string time_pair_start;
        private readonly string time_pair_end;
        private readonly string time_break_start;
        private readonly string time_break_end;
        private readonly Shift shift;
        
        public Pair(string time_pair_start, string time_pair_end, string time_break_start, string time_break_end, Shift shift)
        {
            this.time_pair_start = time_pair_start;
            this.time_pair_end = time_pair_end;
            this.time_break_start = time_break_start;
            this.time_break_end = time_break_end;
            this.shift = shift;
        }

        public string Time_pair_start { get { return time_pair_start; } }
        public string Time_pair_end { get { return time_pair_end; } }
        public string Time_break_start { get { return time_break_start; } }
        public string Time_break_end { get { return time_break_end; } }
        public Shift Shift { get { return shift; } }
    }
}
