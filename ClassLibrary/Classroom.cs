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
    internal class ClassRoom
    {
        private string name;
        private Employee employee;
        private int countPlaces;
        private int countWindows;
        private Equipment[] equipment;
        public ClassRoom(string name, Employee employee, int countPlaces, int countWindows, Equipment[] equipment)
        {
            this.name = name;
            this.employee = employee;
            this.countPlaces = countPlaces;
            this.countWindows = countWindows;
            this.equipment = equipment;
        }

        public string Number
        {
            get { return name; }
        }

        public Employee Employee { get { return employee; } }
        public int Places
        {
            get { return countPlaces; }
        }

        public int Windows
        {
            get { return countWindows; }
        }
    }

    public class Equipment { }
}
