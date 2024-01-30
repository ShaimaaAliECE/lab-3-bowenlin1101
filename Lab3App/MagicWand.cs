using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3App {
    public class MagicWand : Tool {

        public MagicWand(string name) {
            this.description = name;
        }
        
        public override void Display() {
            Console.WriteLine("Magic Wand " +this.description + " is displayed");
        }

        public override void DoAction() {
            Console.WriteLine("Magic Wand is Used");
        }
    }
}