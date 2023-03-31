using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    class Bishop : Piece
    {
        public Bishop(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {

        }

        public Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
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
            if ((given_board.board[attemptedX][attemptedY] != null) && (given_board.board[attemptedX][attemptedY].IsWhite == IsWhite))
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
                        for (int i = 1; i < Math.Abs(attemptedX - PosX); i++)
                        {

                            if (given_board.board[PosX + i][PosY + i] != null)
                            {
                                return null;

                            }
                        }
                        return makeMove(given_board, attemptedX, attemptedY);
                    }
                    //case move is below position in positive diagonal
                    else
                    {
                        for (int i = 1; i < Math.Abs(attemptedX - PosX); i++)
                        {

                            if (given_board.board[PosX - i][PosY - i] != null)
                            {
                                return null;

                            }
                        }
                        return makeMove(given_board, attemptedX, attemptedY);
                    }
                }
                // case negative diagonal
                else
                {
                    //case move is +x in negative diagonal
                    if (attemptedX > PosX)
                    {
                        //checks all the places in that diagonal
                        for (int i = 1; i < Math.Abs(attemptedX - PosX); i++)
                        {

                            if (given_board.board[PosX + i][PosY - i] != null)
                            {
                                return null;

                            }
                        }
                        return makeMove(given_board, attemptedX, attemptedY);
                    }
                    //case move is -x in negative diagonal
                    else
                    {
                        for (int i = 1; i < Math.Abs(attemptedX - PosX); i++)
                        {

                            if (given_board.board[PosX - i][PosY + i] != null)
                            {
                                return null;

                            }
                        }
                        return makeMove(given_board, attemptedX, attemptedY);
                    }
                }
            }

            return null;
        }
    }
}
