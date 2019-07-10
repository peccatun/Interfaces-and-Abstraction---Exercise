using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string command = string.Empty;

            List<Citizen> citizens = new List<Citizen>();

            while ((command = Console.ReadLine()) != "End")
            {
                string[] input = command
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 2)
                {
                    string name = input[0];
                    string id = input[1];

                    Robot robot = new Robot(name, id);

                    citizens.Add(robot);
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];

                    Person person = new Person(name, age, id);

                    citizens.Add(person);
                }
            }

            string bannedId = Console.ReadLine();

            foreach (var citizen in citizens)
            {  
                if (citizen.Id.EndsWith(bannedId))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
