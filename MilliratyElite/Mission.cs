
namespace MilitaryElite
{
    public class Mission
    {
        private string state;

        public Mission(string codeName, string state)
        {
            CodeName = codeName;
            State = state;
        }

        public string CodeName { get; set; }

        public string State
        {
            get
            {
                return this.state;
            }
            set
            {
                if (value == "Finished" || value == "inProgress")
                {
                    this.state = value;
                }
            }
        }

        public override string ToString()
        {
            return $"Code Name: {CodeName} State: {State}".TrimEnd();
        }

        
    }
}
