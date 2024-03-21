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
        private string time_pair_start;
        private string time_pair_end;
        private string time_break_start;
        private string time_break_end;
        private Shift shift;

        public Pair(string time_pair_start, string time_pair_end, string time_break_start, string time_break_end, Shift shift)
        {
            this.time_pair_start = time_pair_start;
            this.time_pair_end = time_pair_end;
            this.time_break_start = time_break_start;
            this.time_break_end = time_break_end;
            this.shift = shift;
        }

        public int Number
        {
            get
            {
                TimeSpan time = TimeSpan.Parse(time_pair_start);
                int hour = time.Hours;
                int minute = time.Minutes;

                if (hour < 8 || hour >= 20)
                {
                    return -1; // Недопустимое время
                }

                if (hour == 8 && minute >= 30)
                {
                    return 1; /// возвращает номер пары на основе времени 
                }

                if (hour == 10 || (hour == 9 && minute >= 40))
                {
                    return 2;
                }

                if (hour == 11 || (hour == 10 && minute >= 50))
                {
                    return 3;
                }

                if (hour == 13 && minute >= 20)
                {
                    return 4;
                }

                if (hour == 15 || (hour == 14 && minute >= 20))
                {
                    return 5;
                }

                if (hour == 16 || (hour == 15 && minute >= 30))
                {
                    return 6;
                }

                if (hour == 17 || (hour == 16 && minute >= 40))
                {
                    return 7;
                }

                return -1; // Недопустимое время
            }
        }
    }
}
