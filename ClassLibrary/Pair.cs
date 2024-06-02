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

    public class Pair
    {
        private readonly TimeSpan startPair;
        private readonly TimeSpan endPair;
        private readonly TimeSpan startBreak;
        private readonly TimeSpan endBreak;

        private readonly Shift shift;

        public Pair(TimeSpan startPair, TimeSpan endPair, TimeSpan startBreak, TimeSpan endBreak, Shift shift)
        {
            this.startPair = startPair;
            this.endPair = endPair;
            this.startBreak = startBreak;
            this.endBreak = endBreak;
            this.shift = shift;
        }

        public TimeSpan StartPair

        {
            get { return startPair; }
        }

        public TimeSpan EndPair
        {
            get { return endPair; }
        }

        public TimeSpan StartBreak
        {
            get { return startBreak; }
        }

        public TimeSpan EndBreak
        {
            get { return endBreak; }
        }

        public Shift Shift { get { return shift; } }
    }
}

