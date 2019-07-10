using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl
{
    public class Robot : Citizen
    {
        public Robot(string model, string id)
        {
            Model = model;
            Id = id;
        }

        public string Model { get; set; }

    }
}
