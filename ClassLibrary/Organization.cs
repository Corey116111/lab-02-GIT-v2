﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    // https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit 12 вариант
    internal class Organisation
    {
        private string name;
        private string legalAdress;
        private string actualAdress;
        private Employee employee;
        public Organisation(string name, string legalAdress, string actualAdress, string refSupervisor)
        {
            this.name = name;
            this.legalAdress = legalAdress;
            this.actualAdress = actualAdress;
            this.employee = employee; 

        }
    }

}
