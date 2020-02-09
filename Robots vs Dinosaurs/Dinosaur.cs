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

        public Dinosaur(string Type, int Health, int Energy, int AttackPower)
        {
            dinoType = Type;
            dinoHealth = Health;
            dinoEnergy = Energy;
            dinoAttackPower = AttackPower;
        }





        //Member Methods

        public void attackRobo(Robot robotToAttack)
        {
            robotToAttack.robotHealth -= dinoAttackPower;
        }
    }
}
