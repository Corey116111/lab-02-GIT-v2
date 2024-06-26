﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    /// <summary>
    /// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit 2 вариант
    /// </summary>
    public class Classroom
    {
        private readonly string name;
        private readonly Employee responsible;
        private readonly int countPlaces;
        private readonly int countWindows;
        private readonly Equipment[] equipment;
        public Classroom(string name, Employee responsible, int countPlaces, int countWindows, Equipment[] equipment)
        {
            this.name = name;
            this.responsible = responsible;
            this.countPlaces = countPlaces;
            this.countWindows = countWindows;
            this.equipment = equipment;
        }

        public string Name { get { return name; } }
        public Employee Responsible { get { return responsible; } }
        public int Places { get { return countPlaces; } }
        public int Windows { get { return countWindows; } }
        public Equipment[] Equipment { get { return equipment; } }
    }
}
