using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
        Herd theHerd;
        Fleet theFleet;


        public void Battle()
        {
     
            theFleet.robot1.attackDinoWithSword(theHerd.dino1);
            theFleet.robot2.attackDinoWithSword(theHerd.dino2);
            theFleet.robot3.attackDinoWithSword(theHerd.dino3);
            theHerd.dino1.attackRobot.(theFleet.robot1);

        }
    }
}
