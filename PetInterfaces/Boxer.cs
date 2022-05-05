using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInterfaces {
    internal class Boxer : IDog {
        public string Color { get; set; } = "Brown";
        public bool IsLarge { get; set; } = true;
        public string Name { get; set; } = "Fred";
        public string Bark() {
            return ("Bow Wow!");
        }

    }
}
