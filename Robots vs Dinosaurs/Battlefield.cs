﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Battlefield
    {
       //Variables
        
        public Herd theHerd;
        public Fleet theFleet;

        //Constructor

            public Battlefield()
        {
            theHerd = new Herd();
            theFleet = new Fleet();

            



                      
        }
       


        //Methods

        public void Battle()
        {
            
            
            
            theFleet.robot1.attackDinoWithSword(theHerd.dino1);
            theFleet.robot2.attackDinoWithSword(theHerd.dino2);
            theFleet.robot3.attackDinoWithSword(theHerd.dino3);
            theHerd.dino1.attackRobo(theFleet.robot1);
            theHerd.dino2.attackRobo(theFleet.robot2);
            theHerd.dino3.attackRobo(theFleet.robot3);

            Console.WriteLine(theHerd.dino1.dinoHealth);
            Console.WriteLine(theHerd.dino2.dinoHealth);
            Console.WriteLine(theHerd.dino3.dinoHealth);
            Console.WriteLine(theFleet.robot1.robotHealth);
            Console.WriteLine(theFleet.robot1.robotHealth);
            Console.WriteLine(theFleet.robot1.robotHealth);
          





        }
        




    }   
    
}
