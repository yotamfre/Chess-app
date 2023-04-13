using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class Piece
    {

        public ImageSource ImageSrc { get; set; }

        public string Name { get; set; }
        public string Color { get; set; }

        public bool IsWhite { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Piece(bool iswhite, int posx, int posy)
        {
            bool IsWhite = iswhite;
            int PosX = posx;
            int PosY = posy;

            getColor();
            ImageSrc = ImageSource.FromResource("ChessMasterGuruWarrior.Images.chessImage.jpg");
        }

        public Board.Board makeMove(Board.Board given_board, int attemptedX, int attemptedY)
        {
            PosX = attemptedX; 
            PosY = attemptedY;

            given_board.board[attemptedX, attemptedY] = this;
            given_board.board[PosX, PosY] = null;

            return given_board;
        }

        public void getColor()
        {
            if (((PosX + PosY) % 2) == 0)
            {
                Color = "#FFFFFF";
            }
            else
            {
                Color = "#000000";
            }
        }


    }
}

