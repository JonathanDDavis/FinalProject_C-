using System;

namespace FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userValue = Console.ReadLine();
            Console.WriteLine("It is nice to meet you " + userValue);

            string CharacterCreated = "no";
            while (CharacterCreated == "yes")
            {
                Character.createChar();
            }

            string newGame = "yes";
            while (newGame == "yes")
            {
                Console.WriteLine("You are a warrior human. *in later versions you can select your race and class* You wake up in a cave. " +
                    "You look around and all you see is a door leading the way out. You walk through the door. When you go through the door " +
                    "there is a giant rat right outside.");


                if (Character.CharStats(alive) == false)
                {
                    Console.WriteLine("Your character has died." +
                        "Do you want to play again?");
                    string playAgain = Console.ReadLine();
                    if (playAgain == "yes")

                        Console.WriteLine("Okay we will start over then");


                    else if (playAgain == "no")
                    {
                        Console.WriteLine("Okay have a nice day!");
                        newGame = "no";
                    }
                    
                }
               
                bool inFight = true;
                while (inFight == true)
                {
                    fights firstfight = new fights();
                    firstfight.enemyMaxHealth = Enemies.giantRat(enemyMaxHealth);
                    firstfight.enemyHealth = Enemies.giantRat(enemyHealth);
                    firstfight.enemyAttDmg = Enemies.giantRat(enemyAttDmg);
                    firstfight.enemyAmour = Enemies.giantRat(enemyAmour);

                    fights.battles();
                }

                Console.WriteLine("You killed the giant rat that attacked you. There are two paths to go down one to the left and one to the right. Which path do you want to go down." +
                    "Now that there isn't something trying to kill you, you can look around. You see a " +
                    "dark tunnel in the ground that is barrly lighten up with torches. You pick up on of the torches and walk down the hallway. You are walking" +
                    " down it for about 6 minutes not seeing anything move and all you can hear is your own breath and the sound of you wlaking. The tunnel " +
                    "finally opens up to a room. In the room you see a zombie walking towards you.");
                Console.ReadLine();

                inFight = true;
                while (inFight == true)
                {
                    fights secondfight = new fights();
                    secondfight.enemyMaxHealth = Enemies.zombies(enemyMaxHealth);
                    secondfight.enemyHealth = Enemies.zombies(enemyHealth);
                    secondfight.enemyAttDmg = Enemies.zombies(enemyAttDmg);
                    secondfight.enemyAmour = Enemies.zombies(enemyAmour);

                    fights.battles();
                }

                Console.WriteLine("You kill the zombie. You look around the room and there is only one way you can go. You walk towards that " +
                    "tunnel and you see that it looks like it is about to collapse. You rush through the tunnel before it can. You go in the tunnel " +
                    "listening to hear if anything is going to happen. You start to hear some of the rocks behind you falling so you start to fun. " +
                    "You are running through the tunnel when you start to see a light at the end. You get out of the tunnel right before it collapsed on you. " +
                    "When you got out of the tunnel you could see a giant troll outside the tunnel");
                Console.ReadLine();

                inFight = true;
                while (inFight == true) ;
                {
                    fights bossfight = new fights();
                    bossfight.enemyAmour = Enemies.boss(enemyAmour);
                    bossfight.enemyAttDmg = Enemies.boss(enemyAttDmg);
                    bossfight.enemyHealth = Enemies.boss(enemyHealth);
                    bossfight.enemyMaxHealth = Enemies.boss(enemyMaxHealth);

                    fights.battles();
                }
                Console.WriteLine("You kill the final opsticle in your way to escape. Goodjob and thank you for playing my game.");
                Console.ReadLine();
                Console.WriteLine("Do you want to play again?");
                string playAgain = Console.ReadLine();
                if (playAgain == "yes")

                    Console.WriteLine("Okay we will start over then");


                else if (playAgain == "no")
                {
                    Console.WriteLine("Okay have a nice day!");
                    newGame = "no";
                }
            }
        }
    }


    class Character
    {
        public static void CharStats()
        {
            int AtkDmg = 6;
            int charHealth = 20;
            int charMaxHealth = 20;
            int charAmour = 2;
            bool alive = true;
        }           
    }

    class Enemies
    {
        public static void giantRat()
        {
            int enemyMaxHealth = 30;
            int enemyHealth = 30;
            int enemyAmour = 1;
            int enemyAttack = 3;

        }

        public static void zombies()
        {
            int enemyMaxHealth = 40;
            int enemyHealth = 40;
            int enmeyAmour = 2;
            int enemyAttack = 3;
        }

        public static void boss()
        {
            int enemyMaxHealth = 60;
            int enemyHealth = 60;
            int enmeyAmour = 3;
            int enemyAttack = 4;
        }
    }
    class fights
    {
        public int enemyHealth { get; set; }
        public int enemyMaxHealth { get; set; }
        public int enemyAttDmg { get; set; }
        public int enemyAmour { get; set; }
        public static void battles()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("Attack");
            Console.WriteLine("Block");

            string fight = Console.ReadLine();

            if (fight == "Attack")
            {
                enemyHealth = enemyHealth - (Character.CharStats(AtkDmg) - enemyAmour);
                Console.WriteLine("You lunge your sword at the Rat");
                Console.WriteLine("Giant Rat's Health: " + enemyHealth + " / " + enemyMaxHealth);
                Character.CharStats(charHealth) = Character.CharStats(charHealth) - (enemyAtkDmg - Character.CharStats(charAmour));
                Console.WriteLine("The Giant Rat charges at you, headbutting you, knocking you back.");
                Console.WriteLine("Your Health: " + Character.CharStats(charHealth) + " / 20");
                Console.ReadLine();
            }
        

            if (fight == "block")
            {
                Character.CharStats(charHealth) = Character.CharStats(charHealth) - (enemyAttDmg - 2 * Character.CharStats(charAmour));
            }

            if (enemyHealth <= 0)
            {
                inFight = false;
            }
        }
    }
}
