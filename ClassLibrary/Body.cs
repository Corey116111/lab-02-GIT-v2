using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{   /// <summary>
    /// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit?pli=1 13 вариант
    /// </summary>
    public class Body
    {
        private string name;
        private string address;
        private string TheCommandant;
        private Student student;
        private Organization organization;
        public Body(string name, string address, string TheCommandant, Student student, Organization organization)
        {
            this.name = name;
            this.address = address;
            this.TheCommandant = TheCommandant;
            this.student = student;
            this.organization = organization;
        }

        public string Letter
        {
            get
            {
                if (string.IsNullOrEmpty(name))
                {
                    return string.Empty; /// назвния корпуса нач с буквы
                }
                return name[0].ToString().ToUpper();
            }
        }
    }
}
