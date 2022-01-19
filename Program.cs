using board;
using chess;

// 158

namespace chess_game{
    class Program{
        static void Main(string[] args){
            try{
                Board brd = new Board(8,8);

                brd.putPiece(new Tower(brd, Color.Black), new Position(0,0));
                brd.putPiece(new Tower(brd, Color.Black), new Position(1,3));
                brd.putPiece(new King(brd, Color.Black), new Position(0,2));

                Screen.showBoard(brd);
            }
            catch(BoardException e){
                Console.WriteLine(e.Message);
            }
        }
    }
}