using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessLogic
{
    public static class Board
    {
        public static int[] Square;

        public static Board()
        {

            Square = new int[64];
            Square[0] = Piece.White | Piece.Knight;
        }

    }
}
