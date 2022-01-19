using board;

namespace chess{
    class ChessMatch{
        public Board brd {get; private set; }
        private int turn;
        private Color actualPlayer;
        public bool ended { get; private set;}

        public ChessMatch(){
            brd = new Board(8, 8);
            turn = 1;
            actualPlayer = Color.White;
            ended = false;
            putPieces();
        }

        public void makeMovement(Position origin, Position dest){
            Piece p = brd.removePiece(origin);
            p.oneMovement();
            Piece capturePiece = brd.removePiece(dest);
            brd.putPiece(p, dest);
            
        }

        private void putPieces(){
            brd.putPiece(new Tower(brd, Color.White), new ChessPosition('c',1).toPosition());
            brd.putPiece(new Tower(brd, Color.White), new ChessPosition('c',2).toPosition());
            brd.putPiece(new Tower(brd, Color.White), new ChessPosition('d',2).toPosition());
            brd.putPiece(new Tower(brd, Color.White), new ChessPosition('e',2).toPosition());
            brd.putPiece(new Tower(brd, Color.White), new ChessPosition('e',1).toPosition());
            brd.putPiece(new King(brd, Color.White), new ChessPosition('d',1).toPosition());
        }
    }
}