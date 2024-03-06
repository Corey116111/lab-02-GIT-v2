using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit
    /// </summary>
    class Classroom
    {
        private string name;
        private Employee employee;
        private int count_places;
        private int count_windows;
        private Body[] bodies;
        public Classroom(string name, Employee employee, int count_places, int count_windows, Body[] bodies)
        {
            this.name = name;
            this.employee = employee;
            this.count_places = count_places;
            this.count_windows = count_windows;
            this.bodies = bodies;
        }
    }
}
