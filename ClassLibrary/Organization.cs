﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1JN0SjEeelhtpKzoJqkva5JRePiMCLzyYPcI0Je8m7qU/edit 12 вариант
    /// </summary>

    public class Organization
    {
        private readonly string name;
        private readonly string legalAdress;
        private readonly string actualAdress;
        private readonly Employee director;
        public Organization(string name, string legalAdress, string actualAdress, Employee director)
        {
            this.name = name;
            this.legalAdress = legalAdress;
            this.actualAdress = actualAdress;
            this.director = director;
        }

        public string Name { get { return name; } }
        public string LegalAdress { get { return legalAdress; } }
        public string ActualAdress { get { return actualAdress; } }
        public Employee Employee { get { return director; } }

    }
}
