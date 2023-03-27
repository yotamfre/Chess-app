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
        public Pawn(bool hasmoved, bool iswhite, int posx, int posy, string piecetype) : base(iswhite, posx, posy, piecetype)
        {
            HasMoved = hasmoved;
            //Optional: if ((iswhite = true AND rank 2) OR(iswhite = false AND rank 7)) --> hasmoved = no, else hasmoved = yes

        }

        public string[] CheckLegalMoves(/*Board Board.board*/)
        {
            var PossibleMoves = new ArrayList();

            if (board[PosX - 1][PosY - 1].IsWhite != this.IsWhite) //Take left
            {
                PossibleMoves.Add((PosX - 1).ToString() + (PosY - 1).ToString());
            }

            if (board[PosX - 1][PosY + 1] != this.IsWhite) //Take right
            {
                PossibleMoves.Add((PosX - 1).ToString() + (PosY + 1).ToString());
            }

            if (Board[PosX - 1][PosY].piecetype.Equals(null)) //Move up 1
            {
                PossibleMoves.Add((PosX - 1).ToString() + (PosY).ToString());
                if (Board[PosX - 2][PosY].piecetype.Equals(null) && HasMoved == false) //Move up 2  ------ NEED to add a var that tracks 1 move AFTER a pawn moves 2 spaces --> in order to do en pasant
                {
                    PossibleMoves.Add((PosX - 2).ToString() + (PosY).ToString());
                }
            }

            //Promotion Section

            if ((PosX == 0 && IsWhite == true) || (PosX == 7 && IsWhite == false))
            {
                //CALL PROMOTION METHOD!!!
            }

            //En Pasant Section

        }
    }
}
