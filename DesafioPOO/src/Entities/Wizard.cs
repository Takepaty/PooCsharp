using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, int HP, int MP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.HeroType = HeroType;
        }

         public override string Attack()
        {
            return this.Name + " Lançou a sua magia!";
        }

        public string Attack(int Bonus)
        {                       
            if (Bonus > 10)
            {
                return this.Name + " Lançou a sua Magia Super efetiva!" + "\n" + "Bonus de: " + Bonus + " Up!!" + "\n" + HP + " HP\n" + MP + " MP\n";
            }

            else
            {
                return this.Name + " Lançou uma magia muito fraca!" + "\n" + "Bonus de: " + Bonus + " Down!" + "\n" + HP + " HP\n" + MP + " MP\n";
            }            
        }
    }
}
