using System;
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

        string swordOrGun;

               
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

            swordOrGun = "sword";
          

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

            Console.WriteLine("Enter sword or gun for Robot fleet weapon :");
            swordOrGun = Console.ReadLine();

            while (theHerd.dinosaurs[0].dinoHealth + theHerd.dinosaurs[1].dinoHealth + theHerd.dinosaurs[2].dinoHealth > 0 && theFleet.robots[0].robotHealth + theFleet.robots[1].robotHealth + theFleet.robots[2].robotHealth > 0) 
            {
                //Participants Attack
               
                if(swordOrGun == "sword")
                {
                    theFleet.robots[0].attackDinoWithSword(theHerd.dinosaurs[0]);
                    theFleet.robots[1].attackDinoWithSword(theHerd.dinosaurs[1]);
                    theFleet.robots[2].attackDinoWithSword(theHerd.dinosaurs[2]);
                    theHerd.dinosaurs[0].attackRobo(theFleet.robots[0]);
                    theHerd.dinosaurs[1].attackRobo(theFleet.robots[1]);
                    theHerd.dinosaurs[2].attackRobo(theFleet.robots[2]);
                }

                else if(swordOrGun == "gun")
                {
                    theFleet.robots[0].attackDinoWithGun(theHerd.dinosaurs[0]);
                    theFleet.robots[1].attackDinoWithGun(theHerd.dinosaurs[1]);
                    theFleet.robots[2].attackDinoWithGun(theHerd.dinosaurs[2]);
                    theHerd.dinosaurs[0].attackRobo(theFleet.robots[0]);
                    theHerd.dinosaurs[1].attackRobo(theFleet.robots[1]);
                    theHerd.dinosaurs[2].attackRobo(theFleet.robots[2]);
                }

                //Write Results

                Console.WriteLine("Battle # :" + battleCount);
                battleCount++;
                
                Console.WriteLine("Dinosaur 1, Health:  " + theHerd.dinosaurs[0].dinoHealth);
                Console.WriteLine("Dinosaur 2, Health:  " + theHerd.dinosaurs[1].dinoHealth);
                Console.WriteLine("Dinosaur 3, Health:  " + theHerd.dinosaurs[2].dinoHealth);
                Console.WriteLine("Robot 1, Health:  " + theFleet.robots[0].robotHealth);
                Console.WriteLine("Robot 2, Health:  " + theFleet.robots[1].robotHealth);
                Console.WriteLine("Robot 3, Health:  " + theFleet.robots[2].robotHealth);

                Console.ReadLine();

                
               if(theHerd.dinosaurs[0].dinoHealth + theHerd.dinosaurs[1].dinoHealth + theHerd.dinosaurs[2].dinoHealth <= 0 && theFleet.robots[0].robotHealth + theFleet.robots[1].robotHealth + theFleet.robots[2].robotHealth > 0)
                {
                    Console.WriteLine("Robots Win");
                }

               if(theFleet.robots[0].robotHealth + theFleet.robots[1].robotHealth + theFleet.robots[2].robotHealth <= 0 && theHerd.dinosaurs[0].dinoHealth + theHerd.dinosaurs[1].dinoHealth + theHerd.dinosaurs[2].dinoHealth > 0)
                {
                    Console.WriteLine("Dinosaurs Win");
                }

              
                                             
               



            }

            
                
                
        }
            
           
          

        
        
          
        



    }   
    
}
