namespace board{
    class Piece{
        public Position position {get; set;}
        public Color color {get; protected set;}
        public int qntMovements {get; protected set;}
        public Board brd {get; protected set;}

        public Piece(Position position, Board brd, Color color){
            this.position = position;
            this.brd = brd;
            this.color = color;
            this.qntMovements = 0;
        }
    }
}