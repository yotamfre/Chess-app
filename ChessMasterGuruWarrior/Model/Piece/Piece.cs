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

        public bool IsWhite { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }

        public Piece(bool iswhite, int posx, int posy)
        {
            bool IsWhite = iswhite;
            int PosX = posx;
            int PosY = posy;

            ImageSrc = ImageSource.FromResource("ChessMasterGuruWarrior.Images.chessImage.jpg");
        }

        public Board.Board makeMove(Board.Board given_board, int attemptedX, int attemptedY)
        {
            PosX = attemptedX; 
            PosY = attemptedY;

            given_board.board[attemptedX, attemptedY] = this;

            bool is_white = false;
            if (((PosX + PosY) % 2) == 0)
            {
                is_white = true;
            }

            given_board.board[PosX, PosY] = new EmptySquare(is_white, PosX, PosY);

            return given_board;
        }

    }
}

