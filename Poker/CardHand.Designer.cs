namespace Poker
{
    partial class CardHand
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cardPanel5 = new Poker.CardPanel();
            this.cardPanel4 = new Poker.CardPanel();
            this.cardPanel3 = new Poker.CardPanel();
            this.cardPanel2 = new Poker.CardPanel();
            this.cardPanel1 = new Poker.CardPanel();
            this.SuspendLayout();
            // 
            // cardPanel5
            // 
            this.cardPanel5.CardHeld = false;
            this.cardPanel5.Location = new System.Drawing.Point(719, 3);
            this.cardPanel5.Name = "cardPanel5";
            this.cardPanel5.Size = new System.Drawing.Size(173, 264);
            this.cardPanel5.TabIndex = 1;
            // 
            // cardPanel4
            // 
            this.cardPanel4.CardHeld = false;
            this.cardPanel4.Location = new System.Drawing.Point(540, 3);
            this.cardPanel4.Name = "cardPanel4";
            this.cardPanel4.Size = new System.Drawing.Size(173, 264);
            this.cardPanel4.TabIndex = 1;
            // 
            // cardPanel3
            // 
            this.cardPanel3.CardHeld = false;
            this.cardPanel3.Location = new System.Drawing.Point(361, 3);
            this.cardPanel3.Name = "cardPanel3";
            this.cardPanel3.Size = new System.Drawing.Size(173, 264);
            this.cardPanel3.TabIndex = 1;
            // 
            // cardPanel2
            // 
            this.cardPanel2.CardHeld = false;
            this.cardPanel2.Location = new System.Drawing.Point(182, 3);
            this.cardPanel2.Name = "cardPanel2";
            this.cardPanel2.Size = new System.Drawing.Size(173, 264);
            this.cardPanel2.TabIndex = 1;
            // 
            // cardPanel1
            // 
            this.cardPanel1.CardHeld = false;
            this.cardPanel1.Location = new System.Drawing.Point(3, 3);
            this.cardPanel1.Name = "cardPanel1";
            this.cardPanel1.Size = new System.Drawing.Size(173, 264);
            this.cardPanel1.TabIndex = 0;
            // 
            // CardHand
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.cardPanel1);
            this.Controls.Add(this.cardPanel2);
            this.Controls.Add(this.cardPanel3);
            this.Controls.Add(this.cardPanel4);
            this.Controls.Add(this.cardPanel5);
            this.MaximumSize = new System.Drawing.Size(897, 270);
            this.MinimumSize = new System.Drawing.Size(897, 270);
            this.Name = "CardHand";
            this.Size = new System.Drawing.Size(897, 270);
            this.Load += new System.EventHandler(this.CardHand_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CardPanel cardPanel1;
        private CardPanel cardPanel2;
        private CardPanel cardPanel3;
        private CardPanel cardPanel4;
        private CardPanel cardPanel5;
    }
}
