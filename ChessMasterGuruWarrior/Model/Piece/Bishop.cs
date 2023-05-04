using System;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    class Bishop : Piece
    {
        public Bishop(bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {
            Name = "Bishop";
        }

        public override Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            //checks if the king is in check
            if (makeMove(given_board, attemptedX, attemptedY, false).IsInCheck(IsWhite))
            {
                Console.WriteLine("is in check");
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
                Console.WriteLine("own piece");
                return null;
            }

            //checks if move is diagonal
            if ((Math.Abs(attemptedX - attemptedY) == Math.Abs(PosX - PosY)) || ((attemptedX + attemptedY) == (PosX + PosY)))
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
                                Console.WriteLine("above in positive diagonal");
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
                                Console.WriteLine("below in positive diagonal");
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
                            Console.WriteLine("-x in negative diagonal + 1");

                            if (given_board.board[PosX + i, PosY - i].GetType() != typeof(EmptySquare))
                            {
                                Console.WriteLine("+x in negative diagonal");
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
                            Console.WriteLine("-x in negative diagonal + 1");

                            if (given_board.board[PosX - i, PosY + i].GetType() != typeof(EmptySquare))
                            {
                                Console.WriteLine("-x in negative diagonal");
                                return null;

                            }
                        }
                        return makeMove(given_board, attemptedX, attemptedY);
                    }
                }
            }

            Console.WriteLine("got to the end");
            return null;
        }
    }
}
