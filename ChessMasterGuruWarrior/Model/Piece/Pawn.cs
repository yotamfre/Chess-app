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

        }

        public Board.Board Move(Board.Board given_board, int attemptedX, int attemptedY)
        {
            //checks if the king is in check
            if (makeMove(given_board, attemptedX, attemptedY).IsInCheck(IsWhite))
            {
                return null;
            }

            if (IsWhite == true) // Moves for WHITE piees
            {
                if (given_board.board[PosX - 1, PosY - 1] != null && given_board.board[PosX - 1, PosY - 1].IsWhite != this.IsWhite) //Take left
                {
                    return makeMove(given_board, attemptedX, attemptedY);
                }

                if (given_board.board[PosX - 1, PosY + 1] != null && given_board.board[PosX - 1, PosY + 1].IsWhite != this.IsWhite) //Take right
                {
                    return makeMove(given_board, attemptedX, attemptedY);
                }

                if (given_board.board[PosX - 1, PosY] == null) //Move up 1
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }
                if (given_board.board[PosX - 2, PosY] == null && HasMoved == false) //Move up 2  ------ NEED to add a var that tracks 1 move AFTER a pawn moves 2 spaces --> in order to do en pasant
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }


                


                //EN PASSANT:

            }

            else //Moves for BLACK pieces
            {
                if (given_board.board[PosX + 1, PosY - 1] != null && given_board.board[PosX + 1,PosY - 1].IsWhite != this.IsWhite) //Take left
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }

                if (given_board.board[PosX + 1, PosY + 1] != null && given_board.board[PosX + 1, PosY + 1].IsWhite != this.IsWhite) //Take right
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }

                if (given_board.board[PosX + 1, PosY] == null) //Move up 1
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }
                if (given_board.board[PosX + 2, PosY] == null && HasMoved == false) //Move up 2  ------ NEED to add a var that tracks 1 move AFTER a pawn moves 2 spaces --> in order to do en pasant
                {
                    return makeMove (given_board, attemptedX, attemptedY);
                }


                


                //EN PASSANT:
            }

            return null;
        }


        private Board.Board makeMove(Board.Board given_board, int attemptedX, int attemptedY)
        {
            //check for PROMOTION
            if ((attemptedX == 0 && IsWhite == false) || (attemptedX == 7 && IsWhite == true))
            {
                //Call promotion
            }

            given_board.board[attemptedX, attemptedY] = this;
            given_board.board[PosX, PosY] = null;

            return given_board;
        }
    }
}
