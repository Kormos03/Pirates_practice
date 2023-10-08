using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pirates_10_05_practice
{
    internal class Ship
    {
        List<Pirate> pirates;
        private Pirate captain;
        private int drunkPirates;
        private int alivePirates;

        public Ship()
        {
            Pirates = new List<Pirate>();
            Captain = new Pirate();
        }

        internal List<Pirate> Pirates { get => pirates; set => pirates = value; }
        internal Pirate Captain { get => captain; set => captain = value; }
        public int DrunkPirates { get => drunkPirates; set => drunkPirates = value; }

        public void fillShip()
        {
            Captain.Name = "Captain";
            int randomPirates = Pirate.rand.Next(1, 113);
            for (int i = 0; i < randomPirates; i++)
            {
                this.alivePirates++;
                Pirates.Add(new Pirate());
            }
            //Console.WriteLine(Captain.ToString());
            // Console.WriteLine(randomPirates);
        }

        public Ship battle(Ship ship1)
        {
            if(this.alivePirates - this.captain.Drinkrum > ship1.alivePirates - ship1.captain.Drinkrum)
            {
                int random = Pirate.rand.Next(1, ship1.alivePirates);
                for(int i = 0; i < random; i++) 
                {
                    ship1.pirates.Remove(new Pirate());
                    ship1.alivePirates--;


                }
                int crewdrink = Pirate.rand.Next(1, this.alivePirates);
                for (int i = 0; i < crewdrink; i++)
                {
                    this.pirates[i].drinkSomeRum();
                    this.DrunkPirates++;
                }
                this.captain.drinkSomeRum();
                return this;
            }
            else
            {
                int random = Pirate.rand.Next(1, ship1.alivePirates);
                for (int i = 0; i < random; i++)
                {
                    this.pirates.Remove(new Pirate());
                    this.alivePirates--;
                }
                int crewdrink = Pirate.rand.Next(1, ship1.alivePirates);
                for (int i = 0; i < crewdrink; i++)
                {
                    ship1.pirates[i].drinkSomeRum();
                    ship1.DrunkPirates++;
                }
                ship1.captain.drinkSomeRum();
                return ship1;
            }
          
        }

        public void info()
        {
           
            Console.WriteLine(captain.ToString());
            Console.WriteLine($"Pirates on the ship {alivePirates}/{pirates.Count} \n Number of rum they drank: {DrunkPirates}");
        }

    }
}
