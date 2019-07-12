
using System.Text;

namespace MilitaryElite
{
    public class Spy : ISpy , ISoldier
    {
        public Spy(int id,string firstName, string lastName, int codeNumber)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CodeNumber = codeNumber;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int CodeNumber { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Name: {FirstName} {LastName} Id: {Id}");
            sb.AppendLine($"Code Number: {CodeNumber}");
            return sb.ToString().TrimEnd();
        }
    }
}
