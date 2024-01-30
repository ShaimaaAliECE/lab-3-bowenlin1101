using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lab3App {
    public abstract class Collectable : Displayable {
        public string description;
        public CollectionBoard board;

        public CollectionBoard Board {
            get {return board;}
            set {board = value;}
        }

        public virtual void AddMe(List<Collectable> list){
            Console.WriteLine(description + " Collected, Congrats!!!!");
            list.Add(this);
        }

        public abstract void Display();
    }
}