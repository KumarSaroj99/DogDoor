using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DougDogDoorAPP.Models
{
    internal class Dog
    {
        private string Name { get; set; }

        public Dog(string name)
        {
            Name = name;
        }

        public string GetName()
        {
            return Name;
        }

        public string Bark()
        {
            return ($"{Name} barks.");
            
        }
    }
}
