using board;

namespace chess{
    class Tower : Piece{
        public Tower(Board brd, Color color): base(brd, color){

        }

        private bool canMove(Position pos){
            Piece p = brd.piece(pos);
            return p == null || p.color != this.color;
        }

        public override bool[,] possibleMovements(){
            bool[,] mat = new bool[brd.lines, brd.columns];

            Position pos = new Position(0,0);

            // N.
            position.defineValue(position.line - 1, position.column);
            while (brd.validPosition(pos) && canMove(pos)){
                mat[pos.line,pos.column] = true;
                if(brd.piece(pos) != null && brd.piece(pos).color != this.color){
                    break;
                }
                pos.line = pos.line - 1;
            }

            // S.
            position.defineValue(position.line + 1, position.column);
            while (brd.validPosition(pos) && canMove(pos)){
                mat[pos.line,pos.column] = true;
                if(brd.piece(pos) != null && brd.piece(pos).color != this.color){
                    break;
                }
                pos.line = pos.line + 1;
            }

            // E.
            position.defineValue(position.line, position.column + 1);
            while (brd.validPosition(pos) && canMove(pos)){
                mat[pos.line,pos.column] = true;
                if(brd.piece(pos) != null && brd.piece(pos).color != this.color){
                    break;
                }
                pos.column = pos.column + 1;
            }

            // W.
            position.defineValue(position.line, position.column - 1);
            while (brd.validPosition(pos) && canMove(pos)){
                mat[pos.line,pos.column] = true;
                if(brd.piece(pos) != null && brd.piece(pos).color != this.color){
                    break;
                }
                pos.column = pos.column - 1;
            } 
            
            return mat;
        }


        public override string ToString()
        {
            return "T";
        }        
    }
}