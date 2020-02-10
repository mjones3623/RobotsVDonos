using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Robot
    {
        //Member Variables
        
        public string robotName;
        public int robotHealth;
        public int robotPowerLevel;
        public int swordStrike;
        List<Weapon> Arsenal;
        public Weapon sword;
        public Weapon gun;
        public Weapon weapon;
               
                       
        
        //Constructor

        

        public Robot(string Name, int RoHealth, int RobotPower, int SwordPower)
        {
            robotName = Name;
            robotHealth = RoHealth;
            robotPowerLevel = RobotPower;
            swordStrike = SwordPower;
            Arsenal = new List<Weapon>();
            sword = new Weapon("Sword", 3);
            gun = new Weapon("Gun", 5);

            Arsenal.Add(sword);
            Arsenal.Add(gun);
            
            
                    
         

        }

        
            


        //Member Methods

        //Robot attack on Dinosaur with sword
        public void attackDinoWithSword(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= Arsenal[0].attackPower;
        }

        //Robot attack on Dinosaur with gun

        public void attackDinoWithGun(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= Arsenal[1].attackPower;
        }

        

    }
}
