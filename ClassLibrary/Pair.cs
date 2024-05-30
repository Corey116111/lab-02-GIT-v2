using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1r4OjKXg5_5yj6ibHB778UEF5Z1nbUqGdXjpQXbTGWiQ/edit 7 вариант
    /// </summary>
    public class Pair //// люди за сомнительную деятельность тимлида ответственности не несут   ㄟ( ▔, ▔ )ㄏ
    {
        private readonly TimeSpan time_pair_start;
        private readonly TimeSpan time_pair_end;
        private readonly TimeSpan time_break_start;
        private readonly TimeSpan time_break_end;
        private readonly Shift shift;

        public Pair(TimeSpan time_pair_start, TimeSpan time_pair_end, TimeSpan time_break_start, TimeSpan time_break_end, Shift shift)
        {
            this.time_pair_start = time_pair_start;
            this.time_pair_end = time_pair_end;
            this.time_break_start = time_break_start;
            this.time_break_end = time_break_end;
            this.shift = shift;
        }
        public TimeSpan Time_pair_start
        {
            get { return time_pair_start; }
        }

        public TimeSpan Time_pair_end
        {
            get { return time_pair_end; }
        }

        public TimeSpan Time_break_start
        {
            get { return time_break_start; }
        }
        public TimeSpan Time_break_end
        {
            get { return time_break_end; }
        }

        public Shift Shift { get { return shift; } }
    }
}

