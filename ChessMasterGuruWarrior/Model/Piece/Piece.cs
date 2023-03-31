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
        public string Type { get; set; }

        public Piece(bool is_white, int posx, int posy, string type)
        {
            bool IsWhite = is_white;
            int PosX = posx;
            int PosY = posy;
            string Type = type;
        }


    }
}
