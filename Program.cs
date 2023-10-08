using Pirates_10_05_practice;


Ship ship1 = new Ship();
Ship ship2 = new Ship();
ship1.Captain.drinkSomeRum();
/*Pirate pirate1 = new Pirate();
Pirate pirate2 = new Pirate();
pirate1.brawl(pirate1, pirate2);
pirate1.drinkSomeRum();
pirate2.drinkSomeRum();
*/
ship1.fillShip();
ship2.fillShip();

ship1.battle(ship2);
ship1.info();
ship2.info();