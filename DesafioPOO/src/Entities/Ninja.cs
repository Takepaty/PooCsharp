using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.src.Entities
{
    public class Ninja :Hero
    {
        public Ninja(string Name, int Level, int HP, int MP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.HeroType = HeroType;
        }

        public override string Attack()
        {
            return this.Name + " Atacou com seu Naginata!";
        }

        public string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " Atacou com seu super Shuriken efetivo!" + "\n" + "Bonus de: " + Bonus + " Up!!" + "\n" + HP + " HP\n" + MP + " MP\n";
            }
            else
            {
                return this.Name + " Está muito fraco, as armas não alcançaram o seu oponente!" + "\n" + "Bonus de: " + Bonus + " Down!" + "\n" + HP + " HP\n" + MP + " MP\n";
            }
        }
    }
}
