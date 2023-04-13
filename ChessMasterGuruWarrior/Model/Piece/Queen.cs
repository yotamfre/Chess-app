using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class Queen : Piece
    {
        public Queen(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {
            Name = "Queen";
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
            if ((given_board.board[attemptedX, attemptedY].GetType() != typeof(EmptySquare)) && (given_board.board[attemptedX, attemptedY].IsWhite == IsWhite))
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

                            if (given_board.board[PosX + i, PosY + i].GetType() != typeof(EmptySquare))
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

                            if (given_board.board[PosX - i, PosY - i].GetType() != typeof(EmptySquare))
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

                            if (given_board.board[PosX + i, PosY - i].GetType() != typeof(EmptySquare))
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

                            if (given_board.board[PosX - i, PosY + i].GetType() != typeof(EmptySquare))
                            {
                                return null;

                            }
                        }
                        return makeMove(given_board, attemptedX, attemptedY);
                    }
                }
            }

            //checks if move is horizontal
            if (attemptedX == PosX)
            {
                //checks if the new position to the right of initial position
                if (attemptedX > PosX)
                {
                    //checks all squares
                    for (int i = 1; i < Math.Abs(attemptedX - PosX); i++)
                    {

                        if (given_board.board[PosX, PosY + i].GetType() != typeof(EmptySquare))
                        {
                            return null;
                        }
                    }
                    return makeMove(given_board, attemptedX, attemptedY);
                }
                //case new position is to the left of initial position
                else
                {
                    for (int i = 1; i < Math.Abs(attemptedX - PosX); i++)
                    {

                        if (given_board.board[PosX, PosY - i].GetType() != typeof(EmptySquare))
                        {
                            return null;
                        }
                    }
                }
            }

            //case move is vertical
            else
            {
                //checks if the new position is above of initial position
                if (attemptedX > PosY)
                {
                    //checks all squares
                    for (int i = 1; i < Math.Abs(attemptedY - PosY); i++)
                    {

                        if (given_board.board[PosX - i, PosY].GetType() != typeof(EmptySquare))
                        {
                            return null;
                        }
                    }
                    return makeMove(given_board, attemptedX, attemptedY);
                }
                //case new position is below initial position
                else
                {
                    for (int i = 1; i < Math.Abs(attemptedY - PosY); i++)
                    {

                        if (given_board.board[PosX - i, PosY].GetType() != typeof(EmptySquare))
                        {
                            return null;
                        }
                    }
                    return makeMove(given_board, attemptedX, attemptedY);
                }
            }

            return null;
        }
    }
}
