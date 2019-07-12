
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class LieutenantGeneral : ILieutenantGeneral , ISoldier
    {
        private List<Private> privates;

        public LieutenantGeneral(int id,string firstName, string lastName, decimal salary)
        {
            Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            privates = new List<Private>();
        }

        public int Id { get ; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set ; }

        public void AddPrivate(Private soldier)
        {
            privates.Add(soldier);
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine("Privates:");
            foreach (var soldier in privates)
            {
                sb.AppendLine("  "+soldier.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
