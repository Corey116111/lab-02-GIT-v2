﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
<<<<<<< HEAD
    /// <summary>
    /// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit 2 вариант
    /// </summary>
=======
>>>>>>> dev
    public class Classroom
    {
        private string name;
        private Employee employee;
        private int count_places;
        private int count_windows;
        //private Equipment[] equipment; -Вариант без владельца
        public Classroom(string name, Employee employee, int count_places, int count_windows)
        {
            this.name = name;
            this.employee = employee;
            this.count_places = count_places;
            this.count_windows = count_windows;
            //this.equipment = equipment;
        }

        public string Number
        {
            get { return name; }
        }

        
        public int Places
        {
            get { return count_places; }
        }

        public int Windows
        {
            get { return count_windows; }
        }
    }
}
