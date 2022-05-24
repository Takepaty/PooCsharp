using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DesafioPOO.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string Name, int Level, int HP, int MP, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HP = HP;
            this.MP = MP;
            this.HeroType = HeroType;
        }       
        
        public string Attack(int Bonus)
        {
            if (Bonus > 10)
            {
                return this.Name + " Atacou com sua super espada de fogo!" + "\n" + "Bonus de: " + Bonus + " Up!!" + "\n" + HP + " HP\n" + MP + " MP\n";
            }
            else
            {
                return this.Name + " Estou sem foças para lutar!" + "\n" +"Bonus de: " + Bonus + " Down!" + "\n" + HP + " HP\n" + MP + " MP\n";
            }          
        }         
   }  
}
