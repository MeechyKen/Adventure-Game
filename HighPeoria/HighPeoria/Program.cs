namespace HighPeoria
{
    public class Program 
    {
       public static Player currentPlayer = new Player();
        public static bool mainLoop = true;
        static void Main(string[] agrs)
        {
            gameTitle();
            start();
            Aliens.FirstAlien(); 
            while (mainLoop)
            {
                Aliens.RandomAlien();
            }
        }
        public static void gameTitle()
        {
            //Title font from http://www.patorjk.com/software/taag/#p=testall&f=Graffiti&t=HighPeoria
            Game game = new Game("\r\n ██░ ██  ██▓  ▄████  ██░ ██  ██▓███  ▓█████  ▒█████   ██▀███   ██▓ ▄▄▄      \r\n▓██░ ██▒▓██▒ ██▒ ▀█▒▓██░ ██▒▓██░  ██▒▓█   ▀ ▒██▒  ██▒▓██ ▒ ██▒▓██▒▒████▄    \r\n▒██▀▀██░▒██▒▒██░▄▄▄░▒██▀▀██░▓██░ ██▓▒▒███   ▒██░  ██▒▓██ ░▄█ ▒▒██▒▒██  ▀█▄  \r\n░▓█ ░██ ░██░░▓█  ██▓░▓█ ░██ ▒██▄█▓▒ ▒▒▓█  ▄ ▒██   ██░▒██▀▀█▄  ░██░░██▄▄▄▄██ \r\n░▓█▒░██▓░██░░▒▓███▀▒░▓█▒░██▓▒██▒ ░  ░░▒████▒░ ████▓▒░░██▓ ▒██▒░██░ ▓█   ▓██▒\r\n ▒ ░░▒░▒░▓   ░▒   ▒  ▒ ░░▒░▒▒▓▒░ ░  ░░░ ▒░ ░░ ▒░▒░▒░ ░ ▒▓ ░▒▓░░▓   ▒▒   ▓▒█░\r\n ▒ ░▒░ ░ ▒ ░  ░   ░  ▒ ░▒░ ░░▒ ░      ░ ░  ░  ░ ▒ ▒░   ░▒ ░ ▒░ ▒ ░  ▒   ▒▒ ░\r\n ░  ░░ ░ ▒ ░░ ░   ░  ░  ░░ ░░░          ░   ░ ░ ░ ▒    ░░   ░  ▒ ░  ░   ▒   \r\n ░  ░  ░ ░        ░  ░  ░  ░            ░  ░    ░ ░     ░      ░        ░  ░\r\n                                                                            \r\n");
            Console.Title = game.title;
            Console.WriteLine(game.title);
            Console.WriteLine("(click Enter to Start)");
            Console.ReadLine();
            Console.Clear();
        }

        //credited from Youtube video called C# Tutorial text-Based Adventure"
        static void start()
        {
            //introduction of game
            Console.WriteLine("Type your name and click Enter:");
            currentPlayer.name = Console.ReadLine();
            Console.Clear();
            //Got the ASCll art from ascii.co.uk 
            Console.WriteLine("Your spaceship crashed on an Unknown planet and you have a gun for protection.");
            Console.WriteLine("You will need to defend yourself from Aliens.");
            Console.WriteLine("You will need to find bolts to fix your spacehip and go home.");
            Console.WriteLine(".  . '    .                                             \r\n      '   .            . '            .                +           \r\n              `                          '    . '\r\n        .                         ,'`.                         .\r\n   .                  ..\"    _.-;'    `.              .    \r\n              _.-\"`.##%\"_.--\" ,'        `.           \"#\"     ___,,od000\r\n           ,'\"-_ _.-.--\"\\   ,'            `-_       '%#%',,/////00000HH\r\n         ,'     |_.'     )`/-     __..--\"\"`-_`-._    J L/////00000HHHHM\r\n . +   ,'   _.-\"        / /   _-\"\"           `-._`-_/___\\///0000HHHHMMM\r\n     .'_.-\"\"      '    :_/_.-'                 _,`-/__V__\\0000HHHHHMMMM\r\n . _-\"\"                         .        '   _,////\\  |  /000HHHHHMMMMM\r\n_-\"   .       '  +  .              .        ,//////0\\ | /00HHHHHHHMMMMM\r\n       `                                   ,//////000\\|/00HHHHHHHMMMMMM\r\n.             '       .  ' .   .       '  ,//////00000|00HHHHHHHHMMMMMM\r\n     .             .    .    '           ,//////000000|00HHHHHHHMMMMMMM\r\n                  .  '      .       .   ,///////000000|0HHHHHHHHMMMMMMM\r\n  '             '        .    '         ///////000000000HHHHHHHHMMMMMMM\r\n                    +  .  . '    .     ,///////000000000HHHHHHHMMMMMMMM\r\n     '      .              '   .       ///////000000000HHHHHHHHMMMMMMMM\r\n   '                  . '              ///////000000000HHHHHHHHMMMMMMMM\r\n                           .   '      ,///////000000000HHHHHHHHMMMMMMMM\r\n       +         .        '   .    .  ////////000000000HHHHHHHHMMMMMMhs");
            if (currentPlayer.name == "")
                Console.WriteLine("You can't even remeber your own name....");
            else
                Console.WriteLine("You know your name is " + currentPlayer.name);
            Console.WriteLine("(Click Enter to Continue)");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("_|_\r\n                |\r\n               )A(\r\n               | |\r\n          ,  _+|_|+_  ,\r\n         )A( |:|:|:| )A(\r\n         | |_||H|H||_| |\r\n    ,    | |:|:|:|:|:| |    ,\r\n   )A(_+_| ||H|H|H|H|| |_+_)A(\r\n   | |:|:| |:|:|:|:|:| |:|:| |\r\n   | ||H|| ||H|H|H|H|| ||H|| |\r\n   | |:|:| |:|:|:|:|:| |:|:| |\r\n   |_||H||_||H|===|H||_||H||_|\r\n ~^^\"      ~^^/   \\^^~      \"^^~");
            Console.WriteLine("You explore this planet until you see a strange building on top of a hill");
            Console.WriteLine("You approach the strange building and see an alien seaching inside the building");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("                        .-.      .-.\r\n                  _..--'`;;`-..-';;'`--.._\r\n                .';,    _   `;;'   _    ,;`.\r\n               ;;'  `;;' `;.`;;'.;' `;;'  `;;\r\n              .;;._.;'`;.   `;;'   .;'`;._.;;.\r\n            ;'      '`;;`   `;;'   ';;'`      `;\r\n           ;:     .:.  `;;. `--' .;;'  .:.     :;\r\n            ;.   .:|:.     `;;;;'     .:|:.   .;\r\n             `;  `:|:'    .;;'`;;.    `:|:'  ;'\r\n              `;. `:'  .;;'.::::.`;;.  `:' .;'\r\n                `;._.;;' .:`::::':. `;;._.;'\r\n           .::::. `::   (:._.::._.:)   ::' .::::.\r\n      .:::::'  `::.`:_.--.`:::::. .--._:'.::'  `:::::.\r\n    .::'     `:.    `::-.:::\"\"\"\":::.-::'   `::      `::.\r\n  .::'      .::'      | /.^^^..^^^.\\ |      `::        `:.\r\n  :::      .:'::.     \\( `;;;..;;;' )/     .::::       :::\r\n  ::  :  .:':.  `::.   \\            /   .::'  .:     .  ::\r\n  :  ::  .   :     `::.              .::'     :  :   ::  :\r\n .:  :    `.::.       `:.          .:'       .::.'    :  :.\r\n::  :  :   : :::.       `:.      .:'       .::: :   :  :  ::\r\n::  :        :' `:.       :.    .:       .:' `:        :  ::\r\n:::     :   ::    `:.      :.  .:      .:'    ::   :     :::\r\n' :       :::'      :.      `::'      .:      `:::       : `");
            Console.WriteLine("The alien is in front of you");
        }

       




     }






























}
 