using board;

namespace chess_game{
    class Screen{
        public static void showBoard(Board board){
            
            for (int i = 0; i<board.lines; i++){
                for (int j = 0; j<board.lines; j++){
                    if (board.piece(i,j) == null){
                        Console.Write("- ");
                    }
                    else{
                        Console.Write(board.piece(i,j) + " ");
                    }                     
                }
                
                Console.WriteLine();
            }
        }
    }
}