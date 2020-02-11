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

        public string swordOrGun1;
        public string swordOrGun2;
        public string swordOrGun3;

        public string tailOrTeeth1;
        public string tailOrTeeth2;
        public string tailOrTeeth3;




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

            swordOrGun1 = "sword";
            swordOrGun2 = "sword";
            swordOrGun3 = "sword";

            tailOrTeeth1 = "tail";
            tailOrTeeth2 = "tail";
            tailOrTeeth3 = "tail";




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
            Console.WriteLine("For Dinosaur 1 choose either tail or teeth: ");
            tailOrTeeth1 = Console.ReadLine();

            Console.WriteLine("For Dinosaur 2 choose either tail or teeth: ");
            tailOrTeeth2 = Console.ReadLine();

            Console.WriteLine("For Dinosaur 3 choose either tail or teeth: ");
            tailOrTeeth3 = Console.ReadLine();
           
            Console.WriteLine("For Robot 1 choose either sword or gun: ");
            swordOrGun1 = Console.ReadLine();

            Console.WriteLine("For Robot 2 choose either sword or gun: ");
            swordOrGun2 = Console.ReadLine();

            Console.WriteLine("For Robot 3 choose either sword or gun: ");
            swordOrGun3 = Console.ReadLine();

            while (theHerd.dinosaurs[0].dinoHealth + theHerd.dinosaurs[1].dinoHealth + theHerd.dinosaurs[2].dinoHealth > 0 && theFleet.robots[0].robotHealth + theFleet.robots[1].robotHealth + theFleet.robots[2].robotHealth > 0) 
            {
                //Participants Attack

                //Robot
               
                if(swordOrGun1 == "sword")
                {
                    theFleet.robots[0].attackDinoWithSword(theHerd.dinosaurs[0]);
                }
                else if(swordOrGun1 == "gun")
                {
                    theFleet.robots[0].attackDinoWithGun(theHerd.dinosaurs[0]);
                }
                if(swordOrGun2 == "sword")
                {
                    theFleet.robots[1].attackDinoWithSword(theHerd.dinosaurs[1]);
                }
                else if(swordOrGun2 == "gun")
                {
                    theFleet.robots[1].attackDinoWithGun(theHerd.dinosaurs[1]);
                }
                if(swordOrGun3 == "sword")
                {
                    theFleet.robots[2].attackDinoWithSword(theHerd.dinosaurs[2]);
                }
                else if(swordOrGun3 == "gun")
                {
                    theFleet.robots[2].attackDinoWithGun(theHerd.dinosaurs[2]);
                }
               
                
                //Dinosaur 
                if(tailOrTeeth1 == "tail")
                {
                    theHerd.dinosaurs[0].attackRobo(theFleet.robots[0]);
                }
                else if (tailOrTeeth1 == "teeth")
                {
                    theHerd.dinosaurs[0].attackRoboWithTeeth(theFleet.robots[0]);
                }
                if(tailOrTeeth2 == "tail")
                {
                    theHerd.dinosaurs[1].attackRobo(theFleet.robots[1]);
                }
                else if (tailOrTeeth2 == "teeth")
                {
                    theHerd.dinosaurs[1].attackRoboWithTeeth(theFleet.robots[1]);
                }
                if (tailOrTeeth3 == "tail")
                {
                    theHerd.dinosaurs[2].attackRobo(theFleet.robots[2]);
                }
                else if (tailOrTeeth3 == "teeth")
                {
                    theHerd.dinosaurs[2].attackRoboWithTeeth(theFleet.robots[2]);
                }



                //Write Results

                Console.WriteLine("Battle # :" + battleCount);
                battleCount++;

                if (theHerd.dinosaurs[0].dinoHealth <= 0)
                {
                    theHerd.dinosaurs[0].dinoHealth = 0;
                }
                if (theHerd.dinosaurs[1].dinoHealth <= 0)
                {
                    theHerd.dinosaurs[1].dinoHealth = 0;
                }
                if (theHerd.dinosaurs[2].dinoHealth <= 0)
                {
                    theHerd.dinosaurs[2].dinoHealth = 0;
                }
                if (theFleet.robots[0].robotHealth <= 0)
                {
                    theFleet.robots[0].robotHealth = 0;
                }
                if (theFleet.robots[1].robotHealth  <= 0)
                {
                    theFleet.robots[1].robotHealth = 0;
                }
                if (theFleet.robots[2].robotHealth <= 0)
                {
                    theFleet.robots[2].robotHealth = 0;
                }


                Console.WriteLine("Dinosaur 1, Health:  " + theHerd.dinosaurs[0].dinoHealth);
                Console.WriteLine("Dinosaur 2, Health:  " + theHerd.dinosaurs[1].dinoHealth);
                Console.WriteLine("Dinosaur 3, Health:  " + theHerd.dinosaurs[2].dinoHealth);
                Console.WriteLine("Robot 1, Health:  " + theFleet.robots[0].robotHealth);
                Console.WriteLine("Robot 2, Health:  " + theFleet.robots[1].robotHealth);
                Console.WriteLine("Robot 3, Health:  " + theFleet.robots[2].robotHealth);

                Console.ReadLine();


                if (theHerd.dinosaurs[0].dinoHealth + theHerd.dinosaurs[1].dinoHealth + theHerd.dinosaurs[2].dinoHealth <= 0 && theFleet.robots[0].robotHealth + theFleet.robots[1].robotHealth + theFleet.robots[2].robotHealth > 0)
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
