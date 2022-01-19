namespace board{
    abstract class Piece{
        public Position position {get; set;}
        public Color color {get; protected set;}
        public int qntMovements {get; protected set;}
        public Board brd {get; protected set;}

        public Piece(Board brd, Color color){
            this.brd = brd;
            this.position = null;
            this.color = color;
            this.qntMovements = 0;
        }

        public abstract bool[,] possibleMovements();

        public void oneMovement(){
            qntMovements++;
        }
    }
}