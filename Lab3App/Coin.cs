using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App {
    public class Coin : Treasure {

        public int value;

        public Coin (string material, int score, int value) {
            this.value = value;
            this.description = material;
            this.score = score;
        }
        public override void Display() {
            Console.WriteLine("Coin " +this.description + " is displayed");
        }

        public void UpdateTotalValue() {
            board.totalValue += this.value;
        }

        public override void AddMe(List<Collectable> list) {
            base.AddMe(list);
            UpdateTotalValue();
        }
        
    }
}