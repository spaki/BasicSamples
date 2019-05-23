using System;
using System.Collections.Generic;
using System.Text;

namespace BasicSamples
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public int GetBirthYear() => DateTime.UtcNow.Year - Age;
    }
}
