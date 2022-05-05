using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetInterfaces {

    internal interface IDog {
        public string Color { get; set; }
        public bool IsLarge { get; set; }
        public string Name { get; set; }
        public string Bark();

    }
}
