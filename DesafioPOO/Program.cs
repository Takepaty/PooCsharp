using DesafioPOO.src.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO
{
    public class Program
    {
        static void Main(string[] args)
        {
            Knight norngestaet = new Knight("Norngestaet",50,292,601,"Knight");
            Wizard Sophia = new Wizard("Sophia",40,469,555,"White wizard");
            Ninja hattori = new Ninja("Hattori Hanzo",50,600,292,"Ninja");            

            Console.WriteLine(norngestaet.Attack(12));
            Console.WriteLine(Sophia.Attack(12));
            Console.WriteLine(hattori.Attack());           

            Console.ReadLine();
        }
    }
}
