using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public static class Piece
    {
        /*
            Piece can be represented in binary
            Color type
            01 011 White Knight
        */
        public const int None = 0;
        public const int King = 1;
        public const int Pawn = 2;
        public const int Knight = 3;
        public const int Bishop = 4;
        public const int Rook = 5;
        public const int Queen = 6;

        public const int White = 8;
        public const int Black = 16;
    }
}
