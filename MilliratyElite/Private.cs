
namespace MilitaryElite
{
    public class Private : IPrivate , ISoldier
    {
        public Private(int id,string firstName, string lastName,decimal salary)
        {
            this.Id = id;
            this.Salary = salary;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName} {LastName} Id: {Id} Salary: {Salary:f2}".TrimEnd();
        }
    }
}
