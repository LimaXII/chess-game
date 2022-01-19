using board;

namespace chess_game{
    class Screen{
        public static void showBoard(Board board){
            
            for (int i = 0; i<board.lines; i++){
                Console.Write(8 - i + " ");
                for (int j = 0; j<board.lines; j++){
                    if (board.piece(i,j) == null){
                        Console.Write("- ");
                    }
                    else{
                        showPiece(board.piece(i,j));
                        Console.Write(" ");
                    }                     
                }
                Console.WriteLine();
            }
            Console.WriteLine("  a b c d e f g h");
        }

        public static void showPiece(Piece piece){
            if (piece.color == Color.White){
                Console.Write(piece);
            }
            else{
                ConsoleColor aux = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(piece);
                Console.ForegroundColor = aux;
            }
        }
    }
}