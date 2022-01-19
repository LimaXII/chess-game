using board;

namespace chess{
    class King : Piece{
        public King(Board brd, Color color): base(brd, color){

        }
        public override string ToString()
        {
            return "R";
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
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            // NE.
            position.defineValue(position.line - 1, position.column + 1);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            // E.
            position.defineValue(position.line, position.column + 1);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            // SE.
            position.defineValue(position.line + 1, position.column + 1);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            // S.
            position.defineValue(position.line + 1, position.column);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            // SE.
            position.defineValue(position.line + 1, position.column - 1);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            //E.
            position.defineValue(position.line, position.column - 1);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            // NE.
            position.defineValue(position.line - 1, position.column - 1);
            if (brd.validPosition(pos) && canMove(pos)){
                mat[position.line, position.column] = true;
            }

            return mat;
        }
    }
}