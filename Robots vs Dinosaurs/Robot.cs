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

        public Robot()
        {
            robotName = null;
            robotHealth = 10;
            robotPowerLevel = 10;
            swordStrike = 2;

        }


        //Member Methods

            //Robot attack on Dinosaur
        public void attackDinoWithSword(Dinosaur dinoToAttack)
        {
            dinoToAttack.dinoHealth -= swordStrike;
        }
    }
}
