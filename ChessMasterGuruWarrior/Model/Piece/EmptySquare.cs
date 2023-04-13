using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    class EmptySquare : Piece
    {

        public EmptySquare(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {
            Name = "empty";
        }
    }
}
