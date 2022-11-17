namespace HighPeoria
{
    public class Aliens
    {
        static Random rand = new Random();
        //Aline Generic


        //Alines
        public static void FirstAlien()
        {
            Console.WriteLine("You grab your gun and charge towards the alien");
            Console.WriteLine("The alien turns...");
            Console.WriteLine("(Click Enter to Continue)");
            Console.ReadKey();
            Combat(false, "normal rank Alien", 1, 4);
        }
        public static void BasicFightAlien()
        {
            Console.Clear();
            Console.WriteLine("As you turn the corner you see another alien...");
            Console.ReadKey();
            Combat(true, "", 0, 0);
        }

        //Aline Tools
        public static void RandomAlien()
        {
            switch (rand.Next(0, 1))
            {
                case 0:
                    BasicFightAlien();
                    break;
            }
        }
        static void Combat(bool random, string name, int ammo, int health)
        {

            string n = "";
            int a = 0;
            int h = 0;
            int s = 0;
            int m = 0;
            int L = 0;
            if (random)
            {
                n = GetName();
                a = rand.Next(1, 5);
                h = rand.Next(1, 8);

                s = Program.currentPlayer.GetSPiece();
                m = Program.currentPlayer.GetMPiece();
                s = Program.currentPlayer.GetLPiece();
            }
            else
            {
                n = name;
                a = ammo;
                h = health;
            }
            while (h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(a + "/" + h);
                Console.WriteLine("====================");
                Console.WriteLine("| (A)ttack (D)efend |");
                Console.WriteLine("|  (R)un    (H)eal  |");
                Console.WriteLine("=====================");
                Console.WriteLine(" Healthpack: " + Program.currentPlayer.ammo + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();
                if (input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //Attack
                    Console.WriteLine("You strike the alien with your gun, but it takes little damage, and the " + n + " strikes you as you move back");
                    int damage = a - Program.currentPlayer.shieldValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.ammo) + rand.Next(1, 4);
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }
                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //Defend
                    Console.WriteLine("As the " + n + " prepares to strike, you take cover behind a rock");
                    int damage = (a / 4) - Program.currentPlayer.shieldValue;
                    if (damage < 0)
                        damage = 0;
                    int attack = rand.Next(0, Program.currentPlayer.ammo) / 2;
                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                    Program.currentPlayer.health -= damage;

                    if (Program.currentPlayer.health <0)
                    {
                        Program.currentPlayer.health = 0;
                    }

                    h -= attack;
                }
                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //Run
                    if (rand.Next(0, 2) == 0)
                    {
                        Console.WriteLine("As you sprint away from the " + n + ", it shoots and strikes you in the back, making you take some damage");
                        int damage = a - Program.currentPlayer.shieldValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("You lose " + damage + " health and are unable to escape ");
                        Console.ReadKey();
                    }
                    else
                    {
                        Console.WriteLine("You evade the " + n + " and you escape with ease!");
                        Console.ReadKey();
                        SpaceShip.LoadSpaceShip(Program.currentPlayer);
                        //go to SpaceShip
                    }
                }
                else if (input.ToLower() == "h" || input.ToLower() == "heal")
                {
                    //Heal
                    if (Program.currentPlayer.Healthpack == 0)
                    {
                        Console.WriteLine("You try to grab a heathpack in your bag, but it is empty");
                        int damage = a - Program.currentPlayer.shieldValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("The " + n + " strikes you with a mighty blow aand you lose " + damage + " health");
                    }
                    else
                    {
                        Console.WriteLine("You reach into your bag and pull out a healthpack, and heal up. ");
                        int HealthpackV = 5;
                        Console.WriteLine("you gain" + HealthpackV + " health");
                        Program.currentPlayer.health += HealthpackV;
                        Console.WriteLine("As you were occupied, the " + n + " advanced and struck.");
                        int damage = (a / 2) - Program.currentPlayer.shieldValue;
                        if (damage < 0)
                            damage = 0;
                        Console.WriteLine("you lose " + damage + "health.");
                    }
                    Console.ReadKey();
                }
                if (Program.currentPlayer.health == 0)
                {
                    //Death code
                    Console.WriteLine("As the " + n + " strikes you, " + n + " stands tall as you are on the ground with 0 health! you have lose to " + n);
                    Console.ReadKey();
                    Console.WriteLine();
                    Console.Clear();
                    System.Environment.Exit(0);
                }
                Console.ReadKey();
            }
            int b = rand.Next(10, 50);
            Console.WriteLine("As you defeat the " + n + ", its body turns into " + b + " bolts!");
            Program.currentPlayer.bolts += b;
            Console.WriteLine("(Click Enter to Continue)");
            Console.Clear();

        }

        static string GetName()
        {
            switch (rand.Next(0, 4))
            {
                case 0:
                    return "alien elite rank";
                case 1:
                    return "alien high rank";
                case 2:
                    return "alien mid rank ";
                case 3:
                    return "alien low rank";
            }
            return "alien normal rank";
        }
         
           
           
    }
}
