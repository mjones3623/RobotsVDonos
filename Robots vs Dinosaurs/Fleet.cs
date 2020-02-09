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
            robot1 = new Robot("roboOne", 10, 10, 5);
            robot2 = new Robot("roboTwo", 10, 10, 5);
            robot3 = new Robot("roboThree", 10, 10, 5);


        }





    }
}
