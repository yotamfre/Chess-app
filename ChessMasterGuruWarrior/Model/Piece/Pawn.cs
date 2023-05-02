using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ChessMasterGuruWarrior.Model.Piece
{
    public class Pawn : Piece
    {

        public bool HasMoved { get; set; }

        //HasMoved - pawn exclusive var
        public Pawn(bool hasmoved, bool iswhite, int posx, int posy) : base(iswhite, posx, posy)
        {
            HasMoved = hasmoved;
            //Optional: if ((iswhite = true AND rank 2) OR(iswhite = false AND rank 7)) --> hasmoved = no, else hasmoved = yes

            Name = "Pawn";

        }

        public override Board.Board move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            Piece attemptedPiece = given_board.board[attemptedX, attemptedY];
            bool isEmpty = attemptedPiece.GetType() == typeof(EmptySquare);
            bool isSamePiece = (attemptedPiece.IsWhite == IsWhite) && (!isEmpty);
            bool isOppositePiece = !(isEmpty || isSamePiece);


            //if the pawn is white
            if (IsWhite)
            {
                if ((attemptedX + 1) == PosX)
                {
                    //trying to move forward
                    if (attemptedY == PosY)
                    {
                        if (isEmpty) 
                        {
                            Console.WriteLine("making move");
                            return makeMove(given_board, attemptedX, attemptedY);
                        }
                        else
                        {
                            Console.WriteLine("isnt empty");
                        }
                    }

                    else
                    {
                        Console.WriteLine("trying to move forward");
                    }

                    //trying to capture
                    if (Math.Abs(attemptedY - PosY) == 1)
                    {
                        if (isOppositePiece)
                        {
                            return makeMove(given_board, attemptedX, attemptedY);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("x: " + PosX + ", " + attemptedX);
                    Console.WriteLine("y: " + PosY + ", " + attemptedY);
                    Console.WriteLine("white and move is legal");
                }
            }

            else
            {
                if ((attemptedX - 1) == PosX)
                {
                    //trying to move forward
                    if (attemptedY == PosY)
                    {
                        if (isEmpty)
                        {
                            return makeMove(given_board, attemptedX, attemptedY);
                        }
                        else 
                        { 
                            Console.WriteLine("isnt empty"); 
                        }
                    }

                    else
                    {
                        Console.WriteLine("trying to move forward");
                    }

                    //trying to capture
                    if (Math.Abs(attemptedY - PosY) == 1)
                    {
                        if (isOppositePiece)
                        {
                            return makeMove(given_board, attemptedX, attemptedY);
                        }
                    }

                }
                else
                {
                    Console.WriteLine("x: " + PosX + ", " + attemptedX);
                    Console.WriteLine("y: " + PosY + ", " + attemptedY);
                    Console.WriteLine("white and move is legal");
                }
            }

            return null;
        }

        public Board.Board oldMove(Board.Board given_board, int attemptedX, int attemptedY)
        { 
            //checks if the king is in check
            if (makeMove(given_board, attemptedX, attemptedY, false).IsInCheck(IsWhite))
            {
                return null;
            }

            if (IsWhite == true) // Moves for WHITE piees
            {
                //the original method of checking the white pieces move legality
                //if (given_board.board[PosX - 1, PosY - 1] != null && given_board.board[PosX - 1, PosY - 1].IsWhite != this.IsWhite) //Take left
                //{
                //    return makeMove(given_board, attemptedX, attemptedY);
                //}

                //if (given_board.board[PosX - 1, PosY + 1] != null && given_board.board[PosX - 1, PosY + 1].IsWhite != this.IsWhite) //Take right
                //{
                //    return makeMove(given_board, attemptedX, attemptedY);
                //}

                //if (given_board.board[PosX - 1, PosY] == null) //Move up 1
                //{
                //    return makeMove (given_board, attemptedX, attemptedY);
                //}
                //if (given_board.board[PosX - 2, PosY] == null && HasMoved == false) //Move up 2  ------ NEED to add a var that tracks 1 move AFTER a pawn moves 2 spaces --> in order to do en pasant
                //{
                //    return makeMove (given_board, attemptedX, attemptedY);
                //}


                if (attemptedX == PosX - 1 && attemptedY == PosY - 1 && given_board.board[PosX - 1, PosY - 1] != null && given_board.board[PosX - 1, PosY - 1].IsWhite != this.IsWhite) //Take left
                {
                    return makeMove(given_board, attemptedX, attemptedY);
                }

                if (attemptedX == PosX - 1 && attemptedY == PosY + 1 && given_board.board[PosX - 1, PosY + 1] != null && given_board.board[PosX - 1, PosY + 1].IsWhite != this.IsWhite) //Take right
                {
                    return makeMove(given_board, attemptedX, attemptedY);
                }

                if (attemptedX == PosX - 1 && attemptedY == PosY && given_board.board[PosX - 1, PosY] == null) //Move up 1
                {
                    return makeMove(given_board, attemptedX, attemptedY);
                }
                if (attemptedX == PosX - 2 && attemptedY == PosY && given_board.board[PosX - 2, PosY] == null && HasMoved == false) //Move up 2  ------ NEED to add a var that tracks 1 move AFTER a pawn moves 2 spaces --> in order to do en pasant
                {
                    return makeMove(given_board, attemptedX, attemptedY);
                }


                //EN PASSANT:

            }

            else //Moves for BLACK pieces
            {
                if (attemptedX == PosX + 1 && attemptedY == PosY - 1 && given_board.board[PosX + 1, PosY - 1] != null && given_board.board[PosX + 1,PosY - 1].IsWhite != this.IsWhite) //Take left
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }

                if (attemptedX == PosX + 1 && attemptedY == PosY + 1 && given_board.board[PosX + 1, PosY + 1] != null && given_board.board[PosX + 1, PosY + 1].IsWhite != this.IsWhite) //Take right
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }

                if (attemptedX == PosX + 1 && attemptedY == PosY && given_board.board[PosX + 1, PosY] == null) //Move up 1
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }
                if (attemptedX == PosX + 2 && attemptedY == PosY && given_board.board[PosX + 2, PosY] == null && HasMoved == false) //Move up 2  ------ NEED to add a var that tracks 1 move AFTER a pawn moves 2 spaces --> in order to do en pasant
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }


                


                //EN PASSANT:
            }

            return null;
        }

        //could eventually be used as an override method to allow promotion and en passant
        //private Board.Board makeMove(Board.Board given_board, int attemptedX, int attemptedY)
        //{
        //    //check for PROMOTION
        //    if ((attemptedX == 0 && IsWhite == false) || (attemptedX == 7 && IsWhite == true))
        //    {
        //        //Call promotion
        //    }

        //    given_board.board[attemptedX, attemptedY] = this;
        //    given_board.board[PosX, PosY] = null;

        //    return given_board;
        //}
    }
}
