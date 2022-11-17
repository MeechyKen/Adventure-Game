using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighPeoria
{
    public class SpaceShip
    {
        public static void LoadSpaceShip(Player p)
        {
            RunSpaceShip(p);
        }
        public static void RunSpaceShip(Player p)
        {
            int SmallPiecep;
            int MediumPiecep;
            int LargePiecep;
            while (true)  
            {
                SmallPiecep = 100 + 80 * p.SmallPiece;
                MediumPiecep = 200 + 100 * p.MediumPiece;
                LargePiecep = 500 + 50 * p.LargePiece;

         

                Console.Clear();
                Console.WriteLine("         |-(SpaceShip)-|         ");
                Console.WriteLine("=================================");
                Console.WriteLine("| (S)mallPiece  : B" + SmallPiecep);
                Console.WriteLine("| (M)ediumPiece : B" + MediumPiecep);
                Console.WriteLine("| (L)argePiece  : B" + LargePiecep);
                Console.WriteLine("=================================");
                Console.WriteLine("(E)exit");
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine(p.name + "'s Inventory");
                Console.WriteLine("=================================");
                Console.WriteLine("Bolts: " +p.bolts);
                Console.WriteLine("SmallPiece: " + p.SmallPiece);
                Console.WriteLine("MediumPiece: " + p.MediumPiece);
                Console.WriteLine("LargePiece: " + p.LargePiece);
                Console.WriteLine("=================================");


                string input = Console.ReadLine().ToLower();
                if(input == "M" || input == "MediumPiece")
                {
                    TryBuy("MediumPiece", MediumPiecep, p);
                }
                else if(input == "S" || input == "SmallPiece")
                {
                    TryBuy("SmallPiece", SmallPiecep, p);

                }
                else if (input == "L" || input == "LargePiece")
                {
                    TryBuy("LargePiece", LargePiecep, p);

                }
                else if(input == "e" || input == "exit")
                    break;
            }
        }
        static void TryBuy(string item, int cost, Player p)
        {
            if (p.bolts >= cost)
            {
                if (item == "SmallPiece")
                    p.SmallPiece = 100;
                else if (item == "MediumPiece")
                    p.MediumPiece = 300;
                else if (item == "LargePiece")
                    p.LargePiece = 500;
                    
                p.bolts -= cost;
            }
            else
            {
                Console.WriteLine("you don't have enough bolts");
                Console.ReadKey();
            }

            if (p.SmallPiece >9 && p.MediumPiece >9 && p.LargePiece >9)
            {
                Console.WriteLine("You have escape from the alien planet from you fixed spaceship! ");
                Console.WriteLine("_,'/\r\n                                  _.-''._:\r\n                          ,-:`-.-'    .:.|\r\n                         ;-.''       .::.|\r\n          _..------.._  / (:.       .:::.|\r\n       ,'.   .. . .  .`/  : :.     .::::.|\r\n     ,'. .    .  .   ./    \\ ::. .::::::.|\r\n   ,'. .  .    .   . /      `.,,::::::::.;\\\r\n  /  .            . /       ,',';_::::::,:_:\r\n / . .  .   .      /      ,',','::`--'':;._;\r\n: .             . /     ,',',':::::::_:'_,'\r\n|..  .   .   .   /    ,',','::::::_:'_,'\r\n|.              /,-. /,',':::::_:'_,'\r\n| ..    .    . /) /-:/,'::::_:',-'\r\n: . .     .   // / ,'):::_:',' ;\r\n \\ .   .     // /,' /,-.','  ./\r\n  \\ . .  `::./,// ,'' ,'   . /\r\n   `. .   . `;;;,/_.'' . . ,'\r\n    ,`. .   :;;' `:.  .  ,'\r\n   /   `-._,'  ..  ` _.-'\r\n  (     _,'``------''  \r\n   `--''");
            }
        }

    }    

}
