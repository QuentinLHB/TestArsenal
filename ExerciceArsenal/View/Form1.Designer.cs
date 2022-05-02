
namespace ExerciceArsenal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtpWinningDate = new System.Windows.Forms.DateTimePicker();
            this.btnOkDate = new System.Windows.Forms.Button();
            this.lstWins = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNLot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblPlayers = new System.Windows.Forms.Label();
            this.lblLotsWon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpWinningDate
            // 
            this.dtpWinningDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpWinningDate.Location = new System.Drawing.Point(31, 12);
            this.dtpWinningDate.Name = "dtpWinningDate";
            this.dtpWinningDate.Size = new System.Drawing.Size(328, 22);
            this.dtpWinningDate.TabIndex = 0;
            // 
            // btnOkDate
            // 
            this.btnOkDate.Location = new System.Drawing.Point(134, 40);
            this.btnOkDate.Name = "btnOkDate";
            this.btnOkDate.Size = new System.Drawing.Size(75, 23);
            this.btnOkDate.TabIndex = 2;
            this.btnOkDate.Text = "OK";
            this.btnOkDate.UseVisualStyleBackColor = true;
            this.btnOkDate.Click += new System.EventHandler(this.btnOkDate_Click);
            // 
            // lstWins
            // 
            this.lstWins.FormattingEnabled = true;
            this.lstWins.ItemHeight = 16;
            this.lstWins.Location = new System.Drawing.Point(31, 69);
            this.lstWins.Name = "lstWins";
            this.lstWins.Size = new System.Drawing.Size(328, 292);
            this.lstWins.TabIndex = 3;
            this.lstWins.SelectedIndexChanged += new System.EventHandler(this.lstWinnings_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(388, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre de lots :";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Location = new System.Drawing.Point(527, 115);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(0, 17);
            this.lblQuantity.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Lot n° :";
            // 
            // lblNLot
            // 
            this.lblNLot.AutoSize = true;
            this.lblNLot.Location = new System.Drawing.Point(448, 69);
            this.lblNLot.Name = "lblNLot";
            this.lblNLot.Size = new System.Drawing.Size(0, 17);
            this.lblNLot.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(378, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre de joueurs :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Lots gagnés :";
            // 
            // lblPlayers
            // 
            this.lblPlayers.AutoSize = true;
            this.lblPlayers.Location = new System.Drawing.Point(521, 17);
            this.lblPlayers.Name = "lblPlayers";
            this.lblPlayers.Size = new System.Drawing.Size(12, 17);
            this.lblPlayers.TabIndex = 10;
            this.lblPlayers.Text = " ";
            // 
            // lblLotsWon
            // 
            this.lblLotsWon.AutoSize = true;
            this.lblLotsWon.Location = new System.Drawing.Point(687, 17);
            this.lblLotsWon.Name = "lblLotsWon";
            this.lblLotsWon.Size = new System.Drawing.Size(12, 17);
            this.lblLotsWon.TabIndex = 11;
            this.lblLotsWon.Text = " ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblLotsWon);
            this.Controls.Add(this.lblPlayers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblNLot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstWins);
            this.Controls.Add(this.btnOkDate);
            this.Controls.Add(this.dtpWinningDate);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpWinningDate;
        private System.Windows.Forms.Button btnOkDate;
        private System.Windows.Forms.ListBox lstWins;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNLot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblPlayers;
        private System.Windows.Forms.Label lblLotsWon;
    }
}

