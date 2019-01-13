using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Poker
{
    public class CardPanel : UserControl
    {
        private Point mHomeLocation;
        private Card mCard;
        private bool mIsBusy = false;
        /// <summary>
        /// Busy state of card panel.
        /// </summary>
        public bool IsBusy
        {
            get { return mIsBusy; }
        }
        /// <summary>
        /// Hold status of card.
        /// </summary>
        public bool CardHeld
        {
            get
            {
                return mCard == null ? false : mCard.Held;
            }
            set
            {
                if (mCard != null) {
                    mCard.Hold(value);
                }
                Invalidate();
            }
        }
        private Timer mTimer;
        public CardPanel()
        {
            mTimer = new Timer
            {
                Interval = 10
            };
            mTimer.Tick += mTimer_Tick;
            InitializeComponent();
        }
        private void CardPanel_Load(object sender, EventArgs e)
        {
            mHomeLocation = Location;
        }
        private void mTimer_Tick(object sender, EventArgs e)
        {
            if (Location.X - 75 > mHomeLocation.X) {
                Location = new Point(Location.X - 75, Location.Y);
            }
            else
            {
                Location = mHomeLocation;
                mTimer.Stop();
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            if (mCard == null)
            {
                Image b = Properties.Resources.back;
                Width = b.Width;
                Height = b.Height;
                Rectangle rc = new Rectangle(0, 0, b.Width, b.Height);
                ColorMatrix cm = new ColorMatrix();
                ImageAttributes ia = new ImageAttributes();
                cm.Matrix33 = 1F;
                ia.SetColorMatrix(cm);
                e.Graphics.DrawImage(b, rc, 0, 0, b.Width, b.Height, GraphicsUnit.Pixel, ia);
            }
            if (mCard != null)
            {
                Width = mCard.Image.Width;
                Height = mCard.Image.Height;
                Rectangle rc = new Rectangle(0, 0, mCard.Image.Width, mCard.Image.Height);
                ColorMatrix cm = new ColorMatrix();
                ImageAttributes ia = new ImageAttributes();
                cm.Matrix33 = 1F;
                ia.SetColorMatrix(cm);
                e.Graphics.DrawImage(mCard.Image, rc, 0, 0, mCard.Image.Width, mCard.Image.Height, GraphicsUnit.Pixel, ia);
            }
            if (CardHeld)
            {
                using (Font font = new Font("Corbel", 18, FontStyle.Bold, GraphicsUnit.Point))
                {
                    Rectangle rc = new Rectangle(0, (Height / 2) - 17, Width, 34);
                    SolidBrush solidBrush = new SolidBrush(Color.Black);
                    e.Graphics.FillRectangle(solidBrush, rc);
                    TextRenderer.DrawText(e.Graphics, "HELD", font, rc, Color.White);
                    e.Graphics.DrawRectangle(Pens.Black, Rectangle.Round(rc));

                }
            }
            base.OnPaint(e);
        }
        /// <summary>
        /// Sets the card object reference.
        /// </summary>
        /// <param name="Object">Card Object.</param>
        public void SetCardObject(Card Object)
        {
            mCard = Object;
            Invalidate();
            SlideIn();
        }
        /// <summary>
        /// Performs slide in animation
        /// </summary>
        private void SlideIn()
        {
            int startX = Parent.Width + Width;
            Location = new Point(startX, Location.Y);
            mTimer.Start();
        }
        public enum Direction
        {
            LeftToRight,
            RightToLeft,
            TopToBottom,
            BottomToTop
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CardPanel
            // 
            this.Name = "CardPanel";
            this.Size = new System.Drawing.Size(10, 10);
            this.Load += new System.EventHandler(this.CardPanel_Load);
            this.ResumeLayout(false);

        }
    }
}