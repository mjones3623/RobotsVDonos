﻿using System;
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


        public void Battle(Herd theHerd, Fleet theFleet)
        {
     
            theFleet.robot1.attackDinoWithSword(theHerd.dino1);
            theFleet.robot2.attackDinoWithSword(theHerd.dino2);
            theFleet.robot3.attackDinoWithSword(theHerd.dino3);
            theHerd.dino1.attackRobo(theFleet.robot1);
            theHerd.dino2.attackRobo(theFleet.robot2);
            theHerd.dino3.attackRobo(theFleet.robot3);

        }
    }
}
