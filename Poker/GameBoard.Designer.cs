namespace Poker
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDynamicResult = new System.Windows.Forms.Label();
            this.labelStaticBalance = new System.Windows.Forms.Label();
            this.labelDynamicBalance = new System.Windows.Forms.Label();
            this.listViewPrizes = new System.Windows.Forms.ListView();
            this.columnHeaderHand = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBetGroup10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBetGroup20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBetGroup30 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBetGroup40 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderBetGroup50 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.labelStaticBet = new System.Windows.Forms.Label();
            this.labelDynamicBet = new System.Windows.Forms.Label();
            this.labelStaticWin = new System.Windows.Forms.Label();
            this.labelDynamicWin = new System.Windows.Forms.Label();
            this.cardHand1 = new Poker.CardHand();
            this.SuspendLayout();
            // 
            // labelDynamicResult
            // 
            this.labelDynamicResult.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDynamicResult.BackColor = System.Drawing.Color.Transparent;
            this.labelDynamicResult.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDynamicResult.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelDynamicResult.Location = new System.Drawing.Point(55, 260);
            this.labelDynamicResult.Name = "labelDynamicResult";
            this.labelDynamicResult.Size = new System.Drawing.Size(897, 33);
            this.labelDynamicResult.TabIndex = 1;
            this.labelDynamicResult.Text = "GOOD LUCK!";
            this.labelDynamicResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStaticBalance
            // 
            this.labelStaticBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelStaticBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticBalance.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticBalance.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelStaticBalance.Location = new System.Drawing.Point(602, 613);
            this.labelStaticBalance.Name = "labelStaticBalance";
            this.labelStaticBalance.Size = new System.Drawing.Size(350, 27);
            this.labelStaticBalance.TabIndex = 2;
            this.labelStaticBalance.Text = "BALANCE";
            this.labelStaticBalance.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelDynamicBalance
            // 
            this.labelDynamicBalance.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDynamicBalance.BackColor = System.Drawing.Color.Transparent;
            this.labelDynamicBalance.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDynamicBalance.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDynamicBalance.Location = new System.Drawing.Point(608, 640);
            this.labelDynamicBalance.Name = "labelDynamicBalance";
            this.labelDynamicBalance.Size = new System.Drawing.Size(344, 35);
            this.labelDynamicBalance.TabIndex = 3;
            this.labelDynamicBalance.Text = "$0.00";
            this.labelDynamicBalance.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // listViewPrizes
            // 
            this.listViewPrizes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.listViewPrizes.AutoArrange = false;
            this.listViewPrizes.BackColor = System.Drawing.Color.MidnightBlue;
            this.listViewPrizes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listViewPrizes.CausesValidation = false;
            this.listViewPrizes.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderHand,
            this.columnHeaderBetGroup10,
            this.columnHeaderBetGroup20,
            this.columnHeaderBetGroup30,
            this.columnHeaderBetGroup40,
            this.columnHeaderBetGroup50});
            this.listViewPrizes.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewPrizes.ForeColor = System.Drawing.Color.White;
            this.listViewPrizes.FullRowSelect = true;
            this.listViewPrizes.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewPrizes.LabelWrap = false;
            this.listViewPrizes.Location = new System.Drawing.Point(55, 12);
            this.listViewPrizes.MultiSelect = false;
            this.listViewPrizes.Name = "listViewPrizes";
            this.listViewPrizes.Scrollable = false;
            this.listViewPrizes.ShowGroups = false;
            this.listViewPrizes.Size = new System.Drawing.Size(897, 251);
            this.listViewPrizes.TabIndex = 4;
            this.listViewPrizes.UseCompatibleStateImageBehavior = false;
            this.listViewPrizes.View = System.Windows.Forms.View.Details;
            this.listViewPrizes.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.listViewPrizes_ItemSelectionChanged);
            // 
            // columnHeaderHand
            // 
            this.columnHeaderHand.Text = "Hand";
            this.columnHeaderHand.Width = 395;
            // 
            // columnHeaderBetGroup10
            // 
            this.columnHeaderBetGroup10.Text = "Bet 10";
            this.columnHeaderBetGroup10.Width = 93;
            // 
            // columnHeaderBetGroup20
            // 
            this.columnHeaderBetGroup20.Text = "Bet 20";
            this.columnHeaderBetGroup20.Width = 95;
            // 
            // columnHeaderBetGroup30
            // 
            this.columnHeaderBetGroup30.Text = "Bet 30";
            this.columnHeaderBetGroup30.Width = 106;
            // 
            // columnHeaderBetGroup40
            // 
            this.columnHeaderBetGroup40.Text = "Bet 40";
            this.columnHeaderBetGroup40.Width = 104;
            // 
            // columnHeaderBetGroup50
            // 
            this.columnHeaderBetGroup50.Text = "Bet50";
            this.columnHeaderBetGroup50.Width = 104;
            // 
            // labelStaticBet
            // 
            this.labelStaticBet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelStaticBet.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticBet.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticBet.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelStaticBet.Location = new System.Drawing.Point(416, 613);
            this.labelStaticBet.Name = "labelStaticBet";
            this.labelStaticBet.Size = new System.Drawing.Size(180, 27);
            this.labelStaticBet.TabIndex = 5;
            this.labelStaticBet.Text = "BET";
            this.labelStaticBet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDynamicBet
            // 
            this.labelDynamicBet.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDynamicBet.BackColor = System.Drawing.Color.Transparent;
            this.labelDynamicBet.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDynamicBet.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDynamicBet.Location = new System.Drawing.Point(416, 640);
            this.labelDynamicBet.Name = "labelDynamicBet";
            this.labelDynamicBet.Size = new System.Drawing.Size(180, 35);
            this.labelDynamicBet.TabIndex = 6;
            this.labelDynamicBet.Text = "10.00";
            this.labelDynamicBet.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelStaticWin
            // 
            this.labelStaticWin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelStaticWin.BackColor = System.Drawing.Color.Transparent;
            this.labelStaticWin.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStaticWin.ForeColor = System.Drawing.Color.RoyalBlue;
            this.labelStaticWin.Location = new System.Drawing.Point(49, 613);
            this.labelStaticWin.Name = "labelStaticWin";
            this.labelStaticWin.Size = new System.Drawing.Size(361, 27);
            this.labelStaticWin.TabIndex = 7;
            this.labelStaticWin.Text = "WIN";
            this.labelStaticWin.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDynamicWin
            // 
            this.labelDynamicWin.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.labelDynamicWin.BackColor = System.Drawing.Color.Transparent;
            this.labelDynamicWin.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDynamicWin.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.labelDynamicWin.Location = new System.Drawing.Point(49, 640);
            this.labelDynamicWin.Name = "labelDynamicWin";
            this.labelDynamicWin.Size = new System.Drawing.Size(361, 35);
            this.labelDynamicWin.TabIndex = 8;
            this.labelDynamicWin.Text = "$0.00";
            // 
            // cardHand1
            // 
            this.cardHand1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.cardHand1.BackColor = System.Drawing.Color.Transparent;
            this.cardHand1.Location = new System.Drawing.Point(55, 296);
            this.cardHand1.Name = "cardHand1";
            this.cardHand1.Size = new System.Drawing.Size(897, 322);
            this.cardHand1.TabIndex = 9;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1006, 713);
            this.Controls.Add(this.cardHand1);
            this.Controls.Add(this.labelDynamicWin);
            this.Controls.Add(this.labelStaticWin);
            this.Controls.Add(this.labelDynamicBet);
            this.Controls.Add(this.labelStaticBet);
            this.Controls.Add(this.listViewPrizes);
            this.Controls.Add(this.labelDynamicBalance);
            this.Controls.Add(this.labelStaticBalance);
            this.Controls.Add(this.labelDynamicResult);
            this.MinimumSize = new System.Drawing.Size(1022, 752);
            this.Name = "GameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Poker";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelDynamicResult;
        private System.Windows.Forms.Label labelStaticBalance;
        private System.Windows.Forms.Label labelDynamicBalance;
        private System.Windows.Forms.ListView listViewPrizes;
        private System.Windows.Forms.ColumnHeader columnHeaderHand;
        private System.Windows.Forms.ColumnHeader columnHeaderBetGroup10;
        private System.Windows.Forms.ColumnHeader columnHeaderBetGroup20;
        private System.Windows.Forms.ColumnHeader columnHeaderBetGroup30;
        private System.Windows.Forms.ColumnHeader columnHeaderBetGroup40;
        private System.Windows.Forms.ColumnHeader columnHeaderBetGroup50;
        private System.Windows.Forms.Label labelStaticBet;
        private System.Windows.Forms.Label labelDynamicBet;
        private System.Windows.Forms.Label labelStaticWin;
        private System.Windows.Forms.Label labelDynamicWin;
        private CardHand cardHand1;
    }
}

