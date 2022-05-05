using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInterfaces {
    internal class Bully : IDog {
        public string Color { get; set; } = "Grey";
        public bool IsLarge { get; set; } = true;
        public string Name { get; set; } = "Roxy";

        public string Bark() {
            return ("Snarf!");
        }
    }
}
