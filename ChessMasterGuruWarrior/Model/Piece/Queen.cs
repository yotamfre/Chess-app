using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class Queen : Piece
    {
        public Queen(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {

        }

        public Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            //checks that move is not to the same spot the piece is already in
            if ((attemptedX == PosX) && (attemptedY == PosY))
            {
                return null;
            }

            //checks if move is diagonal
            if (Math.Abs(attemptedX - attemptedY) == Math.Abs(PosX - PosY))
            {
                //checks if the move is in a positive diagonal
                if ((attemptedY - PosY) * (attemptedX - PosX) > 0)
                {
                    //checks if the move is above the position
                    if (attemptedX > PosX)
                    {
                        //checks all the places in that diagonal
                        for (int x = PosX; x < 8; x++)
                        {
                            for (int y = PosY; y < 8; y++)
                            {
                                if given_board.board[x][y]
                            }
                        }
                    }
                }
            }

            return null;
        }
    }
}
