using board;
using chess;

namespace chess_game{
    class Program{
        static void Main(string[] args){
            try{
                ChessMatch match = new ChessMatch(); 

                while (!match.ended){
                    Console.Clear();
                    Console.WriteLine();
                    Screen.showBoard(match.brd);
                    Console.WriteLine();
                    Console.Write("Origin:");
                    Position origin = Screen.readChessPosition().toPosition();
                    Console.Write("Destiny:");
                    Position destiny = Screen.readChessPosition().toPosition();

                    match.makeMovement(origin, destiny);
                }                
            }
            catch(BoardException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}