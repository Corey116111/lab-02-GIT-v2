using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Shift
    {
        private string name;
        private string date;

        public Shift(string name, string date)
        {
            this.name = name;
            this.date = DateTime.Today.ToString();
        }
    }
}
