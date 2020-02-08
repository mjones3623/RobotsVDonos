using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Fleet
    {
        //Variables

        public Robot robot1;
        public Robot robot2;
        public Robot robot3;


        //Constructor

        public Fleet()
        {
            robot1 = new Robot("Robo1",10,10,2);
            robot2 = new Robot("Robo2", 10, 10, 2);
            robot3 = new Robot("Robo3", 10, 10, 2);


        }





    }
}
