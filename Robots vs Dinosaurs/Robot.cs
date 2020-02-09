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


        //Constructor

        public Robot(string Name, int RoHealth, int RobotPower, int SwordPower)
        {
            robotName = Name;
            robotHealth = RoHealth;
            robotPowerLevel = RobotPower;
            swordStrike = SwordPower;

        }


        //Member Methods

        //Robot attack on Dinosaur
        public void attackDinoWithSword(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= swordStrike;
        }
    }
}
