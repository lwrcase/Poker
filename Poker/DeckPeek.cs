using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poker
{
    public partial class DeckPeek : Form
    {
        private Card _card;
        private int _count = 0;
        public DeckPeek()
        {
            InitializeComponent();
        }
        private void DeckPeek_Load(object sender, EventArgs e)
        {

        }
        public void SetPeekInfo(Card card, int count)
        {
            _card = card;
            _count = count;
            cardPanel1.SetCardObject(_card);
            label1.Text = count.ToString();
        }
    }
}
