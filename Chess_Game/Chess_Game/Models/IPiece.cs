using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_Game.Models
{
    
    public interface IPiece
    {
        public void Move();
        public int Playerpiece();

    }
}
