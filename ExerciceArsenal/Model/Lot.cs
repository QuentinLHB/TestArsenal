using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceArsenal.Model
{
    class Lot
    {
        private int id;
        private int quantity;

        public Lot(int id, int quantity)
        {
            this.Id = id;
            this.Quantity = quantity;
        }

        public int Quantity { get => quantity; private set => quantity = value; }
        public int Id { get => id; private  set => id = value; }
    }
}
