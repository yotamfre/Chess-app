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

            ImageSrc = ImageSource.FromResource(GetImagePath());

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

        public virtual Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            return null;
        }

        public string GetImagePath()
        {
            if (((PosX + PosY) % 2) == 0)
            {
                if(IsWhite && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteBishop.png";
                }

                if (IsWhite && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteKing.png";
                }

                if (IsWhite && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteKnight.png";
                }

                if (IsWhite && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhitePawn.png";
                }

                if (IsWhite && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteQueen.png";
                }

                if (IsWhite && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteRook.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackBishop.png";
                }

                if (IsWhite == false && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackKing.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackKnight.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackPawn.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackQueen.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackRook.png";
                }

                if (this.GetType() == typeof(EmptySquare))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_Empty";
                }

                return null;
            }

            else
            {
                if (IsWhite && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteBishop.png";
                }

                if (IsWhite && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteKing.png";
                }

                if (IsWhite && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteKnight.png";
                }

                if (IsWhite && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhitePawn.png";
                }

                if (IsWhite && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteQueen.png";
                }

                if (IsWhite && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteRook.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackBishop.png";
                }

                if (IsWhite == false && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackKing.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackKnight.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackPawn.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackQueen.png";
                }

                if (IsWhite == false && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackRook.png";
                }

                if (this.GetType() == typeof(EmptySquare))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_Empty";
                }
                return null;
            }
        }

    }
}

