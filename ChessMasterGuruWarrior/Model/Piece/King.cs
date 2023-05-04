using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class King : Piece
    {
        public King(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {
            Name = "King";
        }

        public override Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            //checks if the king is in check
            if (makeMove(given_board, attemptedX, attemptedY, false).IsInCheck(IsWhite))
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

            //checks if attempted move is 1 square away from the king in any direction
            if ((Math.Abs(PosX - attemptedX) == 1) || (Math.Abs(PosY - attemptedY) == 1))
            {
                return makeMove(given_board, attemptedX, attemptedY);
            }

            return null;
        }
    }
}
