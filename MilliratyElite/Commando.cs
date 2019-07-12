using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class Commando : ICommando , ISoldier
    {
        private List<Mission> missions;
        private object stringBuider;

        public Commando(int id,string firstName, string lastName, decimal salary,string corps)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Salary = salary;
            this.Corps = corps;
            this.missions = new List<Mission>();
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
        public string Corps { get; set; }

        public void AddMissin(Mission mission)
        {
            missions.Add(mission);
        }

        public void CompleteMission(string missionName)
        {
            Mission currentMission = missions.FirstOrDefault(m =>m.CodeName.Equals(missionName));
            if (currentMission != null)
            {
                currentMission.State = "Finished";
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}");
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");

            foreach (var miss in missions)
            {
                sb.AppendLine("  " + miss.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
