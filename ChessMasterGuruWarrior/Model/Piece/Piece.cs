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
            IsWhite = iswhite;
            PosX = posx;
            PosY = posy;

            ImageSrc = ImageSource.FromResource(GetImagePath());

        }

        public Board.Board makeMove(Board.Board given_board, int attemptedX, int attemptedY)
        {
            Board.Board attemptedBoard = new Board.Board();
            attemptedBoard.board = given_board.board.Clone() as Piece[,];

            attemptedBoard.board[attemptedX, attemptedY] = this;

            bool is_white = false;
            if (((PosX + PosY) % 2) == 0)
            {
                is_white = true;
            }

            attemptedBoard.board[PosX, PosY] = new EmptySquare(is_white, PosX, PosY);

            return attemptedBoard;
        }

        public virtual Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            return null;
        }

        //returns the image path of each individual piece/square
        public string GetImagePath()
        {
            
            if (((PosX + PosY) % 2) == 0)
            {
                if (this.IsWhite && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteBishop.png";
                }

                if (this.IsWhite && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteKing.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteKnight.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhitePawn.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteQueen.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_WhiteRook.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackBishop.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackKing.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackKnight.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackPawn.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackQueen.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_BlackRook.png";
                }

                return "ChessMasterGuruWarrior.Model.Image.PieceImages.WB_Empty.png"; ;
            }

            else
            {
                if (this.IsWhite && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteBishop.png";
                }

                if (this.IsWhite && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteKing.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteKnight.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhitePawn.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteQueen.png";
                }

                if (this.IsWhite && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_WhiteRook.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Bishop))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackBishop.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(King))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackKing.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Knight))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackKnight.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Pawn))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackPawn.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Queen))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackQueen.png";
                }

                if (this.IsWhite == false && this.GetType() == typeof(Rook))
                {
                    return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_BlackRook.png";
                }

                return "ChessMasterGuruWarrior.Model.Image.PieceImages.BB_Empty.png";
            }

        }

    }
}

