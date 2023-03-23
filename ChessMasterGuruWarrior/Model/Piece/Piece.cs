using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class Piece
    {
        bool IsWhite { get; set; }
        int PosX { get; set; }
        int PosY { get; set; }
        string Type { get; set; }

        public Piece(bool is_white, int posx, int posy, string type)
        {
            bool IsWhite = is_white;
            int PosX = posx;
            int PosY = posy;
            string Type = type;
        }


    }
}
