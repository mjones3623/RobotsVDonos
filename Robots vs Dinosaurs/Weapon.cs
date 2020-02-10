using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_vs_Dinosaurs
{
    class Weapon
    {
        //Variables
        public string sword;
        public string gun;
        public int attackPower;
        public string WeaponType;
        public List<Weapon> weapons = new List<Weapon>();

        



        //Constructor
        public Weapon(string weaponType, int attackPower)
        {

            this.WeaponType = weaponType;
            this.attackPower = attackPower;

        }
    }
}
