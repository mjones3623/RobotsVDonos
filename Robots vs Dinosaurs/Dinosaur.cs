using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Dinosaur
    {

        //Member Variables

        public string dinoType;
        public int dinoHealth;
        public int dinoEnergy;
        public int dinoAttackPower;

        //Constructor

        public Dinosaur(string dinoType, int dinoHealth, int dinoEnergy, int dinoAttackPower )
        {
            dinoType = null;
            dinoHealth = 10;
            dinoEnergy = 10;
            dinoAttackPower = 2;
        }

        //Member Methods

        public void attackRobo(Robot robotToAttack)
        {
            robotToAttack.robotHealth -= dinoAttackPower;
        }
    }
}
