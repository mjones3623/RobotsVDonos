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

        public Dinosaur dino1;
        public Dinosaur dino2;
        public Dinosaur dino3;

        //Constructor
        public Herd()
        {
            dino1 = new Dinosaur("dino1", 10, 10, 2);
            dino2 = new Dinosaur("dino2", 10, 10, 2);
            dino3 = new Dinosaur("dino3", 10, 10, 2);

        }

        //Member Methods
    }
}
