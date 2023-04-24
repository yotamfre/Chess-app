using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    class Knight : Piece
    {


        public Knight(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {
            Name = "Knight";
        }

        public override Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            //checks if the king is in check
            if (makeMove(given_board, attemptedX, attemptedY).IsInCheck(IsWhite))
            {
                return null;
            }

            //checks that move is not to the same spot the piece is already in
            if ((attemptedX == PosX) && (attemptedY == PosY))
            {
                return null;
            }

            //checks if the attempted move is on a piece of the users own color
            if ((given_board.board[attemptedX, attemptedY].GetType() != typeof(EmptySquare)) && (given_board.board[attemptedX, attemptedY].IsWhite == IsWhite))
            {
                return null;
            }

            //checks if a legal knight move
            int xDiff = Math.Abs(PosX - attemptedX);
            int yDiff = Math.Abs(PosY - attemptedY);
            if(((xDiff + yDiff) == 3) && ((xDiff != 3) && (yDiff != 3)))
            {
                return makeMove(given_board, attemptedX, attemptedY);
            }

            return null;
        }

    }
}
