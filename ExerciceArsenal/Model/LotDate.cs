using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArsenal.Model
{
    class LotDate
    {
        private int idLotDate;
        private int idLot;
        private DateTime winningDate;
        private TimeSpan winningTime;


        public LotDate(int idLotDate, int idLot, DateTime winningDate, TimeSpan winningTime)
        {
            this.idLotDate = idLotDate;
            this.IdLot = idLot;
            this.winningDate = winningDate;
            this.winningTime = winningTime;
        }

        public int IdLot { get => idLot; private set => idLot = value; }

        public override string ToString()
        {
            return $"le {winningDate.Date.ToString()} à {winningTime.ToString()}, lot n° : {IdLot}";
        }
    }


}
