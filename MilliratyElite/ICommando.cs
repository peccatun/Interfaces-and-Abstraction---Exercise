
using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ICommando
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        string Corps { get; set; }

        void AddMissin(Mission mission);
    }
}
