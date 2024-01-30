using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App {
    public class Axe : Tool{

        public Axe(string name) {
            this.description = name;
        }
        public override void Display() {
            Console.WriteLine("Axe " +this.description + " is displayed");
        }

        public override void DoAction() {
            Console.WriteLine("Axe is Used");
        }
    }
}