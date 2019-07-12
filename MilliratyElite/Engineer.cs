
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class Engineer : IEngineer , ISoldier
    {
        private List<Repair> repairs;

        public Engineer(int id, string firstName, string lastName, decimal salary, string corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            repairs = new List<Repair>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set ; }
        public decimal Salary { get ; set; }
        public string Corps { get ; set; }

        public void AddRepair(Repair repair)
        {
            repairs.Add(repair);
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($" Corps: {Corps}");
            sb.AppendLine("Repairs:");
            foreach (var repair in repairs)
            {
                sb.AppendLine("  " + repair.ToString());
            }

            return sb.ToString().TrimEnd();

               
            
        }
    }
}
