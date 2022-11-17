namespace HighPeoria
{
    public class Player
    {
        Random rand = new Random();

        public string name; 
        public int bolts = 100;
        public int health = 10;
        public int damage = 1;
        public int shieldValue = 0;
        public int ammo = 1;
        public int Healthpack = 5;
        public int SmallPiece = 0;
        public int MediumPiece = 0;
        public int LargePiece = 0;

        public int Piece = 0;



        public int GetSPiece()
        {
            int upper = (2 * Piece + 5);
            int lower = (Piece + 2);
            return rand.Next(lower,upper);
        }
        public int GetMPiece() 
        {
            int upper = (2 * Piece + 2);
            int lower = (Piece + 1);
            return rand.Next(lower, upper);
        }
         public int GetLPiece()
        {
            int upper = (2 * Piece + 5);
            int lower = (Piece + 2);
            return rand.Next(lower, upper);
        }
        
            
        
    }
}
