using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExerciceArsenal.Controller;
using ExerciceArsenal.Model;

namespace ExerciceArsenal
{
    public partial class Form1 : Form
    {
        private Controle controller;
        private BindingList<LotDate> bindingList;
        public Form1()
        {
            controller = new Controle();
            InitializeComponent();
            bindingList = new BindingList<LotDate>(controller.Winnings);
            lstWins.DataSource = bindingList;
        }

        private void btnOkDate_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpWinningDate.Value.Date;
            controller.searchWinnings(selectedDate);
            bindingList.ResetBindings();
            lstWinnings_SelectedIndexChanged(null, null);
            WinningHistory winningHistory = controller.searchWinningHistory(selectedDate);
            if (winningHistory == null) return;
            lblPlayers.Text = winningHistory.Players.ToString();
            lblLotsWon.Text = winningHistory.LotsWon.ToString();
        }

        private void lstWinnings_SelectedIndexChanged(object sender, EventArgs e)
        {
            LotDate win = (LotDate)lstWins.SelectedItem;
            if (win == null)
            {
                resetLabels();
                return;
            }
            Lot lot = controller.searchLot(win.IdLot);
            if (lot == null)
            {
                resetLabels();
            }
            lblNLot.Text = lot.Id.ToString();
            lblQuantity.Text = lot.Quantity.ToString();
        }

        private void resetLabels()
        {
            lblNLot.Text = "";
            lblQuantity.Text = "";
        }
    }
}
