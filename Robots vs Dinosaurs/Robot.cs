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
        public Weapon sword;
        public Weapon gun;
        public Weapon weapon;
        public string swordOrGun;
        



        public List<Weapon> weapons = new List<Weapon>();


        //Constructor

        

        public Robot(string Name, int RoHealth, int RobotPower, int SwordPower)
        {
            robotName = Name;
            robotHealth = RoHealth;
            robotPowerLevel = RobotPower;
            swordStrike = SwordPower;
            
            sword = new Weapon("sword", 5);
            gun = new Weapon("gun", 3);
            weapon = new Weapon("weapon", 10);

            weapons.Add(sword);
            weapons.Add(gun);

            swordOrGun = "sword";
           


            

        }

        
            


        //Member Methods

        //Robot attack on Dinosaur with sword
        public void attackDinoWithSword(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= sword.attackPower;
        }

        //Robot attack on Dinosaur with gun

        public void attackDinoWithGun(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= gun.attackPower;
        }

        //Choose Weapon
        public void chooseRobotWeapon()
        {
            Console.WriteLine("For Robot 1 choose either sword or gun: " );
            swordOrGun = Console.ReadLine();

           

            
        }

    }
}
