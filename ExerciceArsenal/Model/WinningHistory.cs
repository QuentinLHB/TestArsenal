using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArsenal.Model
{
    class WinningHistory
    {
        private DateTime date;
        private int players;
        private int lotsWon;

        public WinningHistory(DateTime date, int players, int lotsWon)
        {
            this.date = date;
            this.Players = players;
            this.LotsWon = lotsWon;
        }

        public int Players { get => players; private set => players = value; }
        public int LotsWon { get => lotsWon; private set => lotsWon = value; }
    }
}
