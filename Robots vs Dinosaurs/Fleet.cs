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
        public List<Robot> robots = new List<Robot>();
        public Robot robot1;
        public Robot robot2;
        public Robot robot3;

        


        //Constructor

        public Fleet()
        {
            robot1 = new Robot("roboOne", 15, 10, 5);
            robot2 = new Robot("roboTwo", 15, 10, 3);
            robot3 = new Robot("roboThree", 15, 10, 5);

            robots.Add(robot1);
            robots.Add(robot2);
            robots.Add(robot3);

        }

        //Member Methods



    }
}
