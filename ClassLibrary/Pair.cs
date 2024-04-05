using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Pair
    {
        private readonly DateTime dateHeld;
        private string time_pair_start;
        private string time_pair_end;
        private string time_break_start;
        private string time_break_end;
        private Shift shift;

        public Pair(DateTime dateHeld, string time_pair_start, string time_pair_end, string time_break_start, string time_break_end, Shift shift)
        {
            this.dateHeld = dateHeld != default? dateHeld: DateTime.Now;
            this.time_pair_start = time_pair_start;
            this.time_pair_end = time_pair_end;
            this.time_break_start = time_break_start;
            this.time_break_end = time_break_end;
            this.shift = shift;
        }
    }
}
