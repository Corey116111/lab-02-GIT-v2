using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ClassLibrary

{   /// <summary>
    /// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit?pli=1 13 вариант
    /// </summary>


    public class BuildingBody
    {
        private readonly string name;
        private readonly string address;
        private readonly Employee commandant;
        private readonly Organization organization;

        public BuildingBody(string name, string address, Employee employee, Organization organization)
        {
            this.name = name;
            this.address = address;
            this.commandant = employee; 
            this.organization = organization; 
        }

        public string Name { get { return name; } }
        public string Address { get { return address; } }
        public Employee Employe => commandant;
        public Organization Organization => organization;
    }
}