using ChessMasterGuruWarrior.Model.Board;
using ChessMasterGuruWarrior.Model.Piece;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace ChessMasterGuruWarrior.ViewViewModel.Game
{
    class GameViewModel
    {
        private Board game_board { get; set; }
        public ObservableCollection<ObservableCollection<Piece>> gameBoard { get; }
        private Piece PieceSelected { get; set; }



        public GameViewModel()
        {
            game_board = new Board();
            game_board.MakeBoard();

            gameBoard = new ObservableCollection<ObservableCollection<Piece>>();
            this.loadBoard();
        }

        private void loadBoard()
        {
            for (int r = 0; r < 8; r++)
            {
                gameBoard.Add(new ObservableCollection<Piece>(game_board.getRow(r).ToList()));
            }
        }

        public Command<Piece> PieceClicked
        {
            get
            {
                return new Command<Piece>((Piece p) =>
                {
                    Console.WriteLine("clicked");

                    //checks if there is a piece already selected
                    if(PieceSelected == null)
                    {

                    }
                });
            }
        }
    }
}
