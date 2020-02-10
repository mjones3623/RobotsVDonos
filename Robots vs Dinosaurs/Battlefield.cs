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

        int dino1IsAlive;
        int dino2IsAlive;
        int dino3IsAlive;
        int robot1IsAlive;
        int robot2IsAlive;
        int robot3IsAlive;
        
        int isAliveTotal;

        int battleCount;

               
        //Constructor



        public Battlefield()
        {
            theHerd = new Herd();
            theFleet = new Fleet();

            dino1IsAlive = 1;
            dino2IsAlive = 1;
            dino3IsAlive = 1;
            robot1IsAlive = 1;
            robot2IsAlive = 1;
            robot3IsAlive = 1;

            battleCount = 1;


            isAliveTotal = dino1IsAlive + dino2IsAlive + dino3IsAlive + robot1IsAlive + robot2IsAlive + robot3IsAlive;

        }



        //Methods

        public void AliveTotal()
        {
            isAliveTotal = dino1IsAlive + dino2IsAlive + dino3IsAlive + robot1IsAlive + robot2IsAlive + robot3IsAlive;
        }

        //One Round Of Battle

        public void Battle()
        {

            while(isAliveTotal > 1) 
            {

                theFleet.robot1.attackDinoWithSword(theHerd.dino1);
                theFleet.robot2.attackDinoWithSword(theHerd.dino2);
                theFleet.robot3.attackDinoWithSword(theHerd.dino3);
                theHerd.dino1.attackRobo(theFleet.robot1);
                theHerd.dino2.attackRobo(theFleet.robot2);
                theHerd.dino3.attackRobo(theFleet.robot3);

                Console.WriteLine("Battle # :" + battleCount);
                battleCount++;
                
                Console.WriteLine("Dinosaur 1, Health: " + theHerd.dino1.dinoHealth);
                Console.WriteLine("Dinosaur 2, Health:  " + theHerd.dino2.dinoHealth);
                Console.WriteLine("Dinosaur 3, Health:  " + theHerd.dino3.dinoHealth);
                Console.WriteLine("Robot 1, Health:  " + theFleet.robot1.robotHealth);
                Console.WriteLine("Robot 2, Health:  " + theFleet.robot1.robotHealth);
                Console.WriteLine("Robot 3, Health:  " + theFleet.robot1.robotHealth);

                Console.ReadLine();

                


                if (theHerd.dino1.dinoHealth <= 0)
                {
                    dino1IsAlive = 0;
                }
                if (theHerd.dino2.dinoHealth <= 0)
                {
                    dino2IsAlive = 0;
                }
                if (theHerd.dino3.dinoHealth <= 0)
                {
                    dino3IsAlive = 0;
                }
                if (theFleet.robot1.robotHealth <= 0)
                {
                    robot1IsAlive = 0;
                }
                if (theFleet.robot2.robotHealth <= 0)
                {
                    robot2IsAlive = 0;
                }
                if (theFleet.robot3.robotHealth <= 0)
                {
                    robot3IsAlive = 0;
                }

                //Update Alive Total

                AliveTotal();
                                             
                //Is There A Winner

                if (theHerd.dino1.dinoHealth > 0 && isAliveTotal == 1)
                {
                    Console.WriteLine("Dinosaurs win!");
                }
                if (theHerd.dino2.dinoHealth > 0 && isAliveTotal == 1)
                {
                    Console.WriteLine("Dinosaurs win!");
                }
                if (theHerd.dino3.dinoHealth > 0 && isAliveTotal == 1)
                {
                    Console.WriteLine("Dinosaurs win!");
                }
                if (theFleet.robot1.robotHealth > 0 && isAliveTotal == 1)
                {
                    Console.WriteLine("Robots win!");
                }
                if (theFleet.robot2.robotHealth > 0 && isAliveTotal == 1)
                {
                    Console.WriteLine("Robots win!");
                }
                if (theFleet.robot3.robotHealth > 0 && isAliveTotal == 1)
                {
                    Console.WriteLine("Robots win!");
                }



            }

            
                
                
        }
            
           
          

        
        
          
        



    }   
    
}
