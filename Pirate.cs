using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_10_05_practice
{
    internal class Pirate
    {
        private string name;
        private int drinkrum;
        private bool isDead;
        public static Random rand = new Random();

        public Pirate()
        {
            drinkrum = 0;
        }

        public int Drinkrum { get => drinkrum; set => drinkrum = value; }
        public string Name { get => name; set => name = value; }
        public bool IsDead { get => isDead; set => isDead = value; }

        public void drinkSomeRum()
        {
           if(IsDead == true)
            {
                die();
            }
           else { drinkrum++; }
        }
        public void howaltGoingMate()
        {
            if (IsDead == true)
            {
                die();
            }
            else if(drinkrum < 4 && IsDead == false)
            {
                Console.WriteLine("Pour me anudder");
            }
            else if(drinkrum >= 4 && IsDead == false)
            {
                Console.WriteLine("Arghh, I'ma Pirate. How d'ya d'ink its goin?");
                Console.WriteLine("<The pirate passes out  and sleeps it off>");
                drinkrum = 0;
            }
        }

        public Pirate brawl(Pirate pirate1, Pirate pirate2)
        {
            int random = rand.Next(1,4);
            switch(random)
            {
                case 1:
                    pirate1.IsDead = true;
                    return pirate1;
                    break;
                case 2:
                    pirate2.IsDead = true;
                    return pirate2;
                    break;
                case 3:
                    pirate1.IsDead = true;
                    pirate2.IsDead = true;
                    return pirate2;
            }
            return pirate2;
        }

        public void die()
        {
            IsDead = true;
            Console.WriteLine("He is dead");
        }
       

        public override string ToString()
        {
            string isdead = IsDead ? "Dead" : "Alive";
            return name + " " + drinkrum + " " + isdead;
        }
    }
}
