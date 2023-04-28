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
            Board.Board mov = makeMove(given_board, attemptedX, attemptedY);
            if (mov.IsInCheck(IsWhite))
            {
                return null;
            }

            //checks that move is not to the same spot the piece is already in
            if ((attemptedX == PosX) && (attemptedY == PosY))
            {
                Console.WriteLine("piece is on the same spot");
                return null;
            }

            //checks if the attempted move is on a piece of the users own color
            if ((given_board.board[attemptedX, attemptedY].GetType() != typeof(EmptySquare)) && (given_board.board[attemptedX, attemptedY].IsWhite == IsWhite))
            {
                Console.WriteLine("type: " + given_board.board[attemptedX, attemptedY].GetType());
                Console.WriteLine("own piece");
                return null;
            }

            //checks if a legal knight move
            int xDiff = Math.Abs(PosX - attemptedX);
            int yDiff = Math.Abs(PosY - attemptedY);
            if(((xDiff + yDiff) == 3) && ((xDiff != 3) && (yDiff != 3)))
            {
                PosX = attemptedX;
                PosY = attemptedY;
                return makeMove(given_board, attemptedX, attemptedY);
            }

            return null;
        }

    }
}
