using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    interface IVerticalHorizontalMovement
    {
        bool VerticalHorizontalMovement(int[] pieceSelect, int[] whereToMove, IPiece[,] actualTable);
    }
}
