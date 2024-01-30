using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3App {
    public abstract class Treasure : Collectable {

        public int score;

        public void UpdateTotalScore() {
            board.totalScore += score;
            Console.WriteLine("Total Score is updated to: {0}", board.totalScore);
        }

        public override void AddMe(List<Collectable> list) {
            base.AddMe(list);
            UpdateTotalScore();
        }
    }
}