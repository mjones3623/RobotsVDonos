using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Herd
    {
        //Variables
        public List<Dinosaur> dinosaurs;

        //Constructor
        public Herd()
        {  
            dinosaurs = new List<Dinosaur>() { new Dinosaur("dinoOne", 15, 10, 1), new Dinosaur("dinoTwo", 15, 10, 1), new Dinosaur("dinoThree", 15, 10, 1) };
        }


        //Member Methods
    }
}
