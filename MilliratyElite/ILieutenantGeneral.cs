
using System.Collections.Generic;

namespace MilitaryElite
{
    public interface ILieutenantGeneral
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        void AddPrivate(Private soldier);
    }
}
