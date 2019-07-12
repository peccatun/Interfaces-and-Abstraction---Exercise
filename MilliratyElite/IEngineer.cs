
using System.Collections.Generic;

namespace MilitaryElite
{
    public interface IEngineer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        string Corps { get; set; }

        void AddRepair(Repair repair);

    }
}
