using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class Piece
    {
        public bool IsWhite { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Piece(bool iswhite, int posx, int posy)
        {
            bool IsWhite = iswhite;
            int PosX = posx;
            int PosY = posy;
        }
    }
}

