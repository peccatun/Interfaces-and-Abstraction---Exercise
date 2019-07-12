using System;
using System.Collections.Generic;
using System.Linq;

namespace MilitaryElite
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<ISoldier> soldiers = new List<ISoldier>();
            string command = string.Empty;

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int id = int.Parse(input[1]);
                string firstName = input[2];
                string lastName = input[3];


                switch (input[0])
                {
                    case "Private":
                        Private @private = new Private(id, firstName, lastName, decimal.Parse(input[4]));
                        soldiers.Add(@private);
                        break;
                    case "LieutenantGeneral":
                        decimal salary = decimal.Parse(input[4]);
                        LieutenantGeneral lieutenantGeneral = new LieutenantGeneral(id, firstName, lastName, salary);
                        for (int i = 5; i < input.Length; i++)
                        {
                            ISoldier currentPrivate = soldiers.FirstOrDefault(s => s.Id.Equals(int.Parse(input[i])));
                            if (currentPrivate != null)
                            {
                                if (currentPrivate is Private currentSoldier)
                                {
                                    lieutenantGeneral.AddPrivate(currentSoldier);
                                }
                            }
                        }
                        soldiers.Add(lieutenantGeneral);
                        break;
                    case "Engineer":
                        salary = decimal.Parse(input[4]);
                        string corps = input[5];
                        if (!(corps != "Airforces" || corps != "Marines"))
                        {
                            continue;
                        }
                        Engineer engineer = new Engineer(id, firstName, lastName, salary, corps);

                        for (int i = 6; i < input.Length; i++)
                        {
                            if (i + 1 < input.Length)
                            {
                                if (int.TryParse(input[i + 1], out int repairHours))
                                {
                                    Repair repair = new Repair(input[i], repairHours);
                                    engineer.AddRepair(repair);
                                }
                            }
                        }

                        soldiers.Add(engineer);
                        break;
                    case "Commando":
                        salary = decimal.Parse(input[4]);
                        corps = input[5];
                        if (!(corps != "Airforces" || corps != "Marines"))
                        {
                            continue;
                        }
                        Commando commando = new Commando(id,firstName,lastName,salary,corps);
                        for (int i = 6; i < input.Length; i++)
                        {
                            if (i + 1 < input.Length)
                            {
                                if (input[i + 1] != "inProgress")
                                {
                                    i++;
                                    continue;
                                }
                                Mission mission = new Mission(input[i],input[i + 1]);
                                commando.AddMissin(mission);
                                i++;
                            }
                        }
                        soldiers.Add(commando);
                        break;
                    case "Spy":
                        int codeNumber = int.Parse(input[4]);
                        Spy spy = new Spy(id,firstName,lastName,codeNumber);
                        soldiers.Add(spy);
                        break;

                    default:
                        break;
                }

            }
            foreach (var soldir in soldiers)
            {
                Console.WriteLine(soldir);
            }
        }
    }
}
