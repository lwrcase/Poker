using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Poker
{
    public partial class GameBoard : Form
    {
        IDeck _deckofcards;
        decimal _balance = 0M;
        decimal _bet = 10M;
        KeyboardHook _kbd = new KeyboardHook();
        List<Prize> Prizes = new List<Prize>
        {
            new Prize
            {
                Name = "ROYAL FLUSH",
                Multiplier = 800
            },
            new Prize
            {
                Name = "STRAIGHT FLUSH",
                Multiplier = 50
            },
            new Prize
            {
                Name = "4 ACES",
                Multiplier = 80
            },
            new Prize
            {
                Name = "4 2s, 3s, 4s",
                Multiplier = 40
            },
            new Prize
            {
                Name = "4 5s THRU KINGS",
                Multiplier = 25
            },
            new Prize
            {
                Name = "FULL HOUSE",
                Multiplier = 8
            },
            new Prize
            {
                Name = "FLUSH",
                Multiplier = 5
            },
            new Prize
            {
                Name = "STRAIGHT",
                Multiplier = 4
            },
            new Prize
            {
                Name = "3 OF A KIND",
                Multiplier = 3
            },
            new Prize
            {
                Name = "TWO PAIR",
                Multiplier = 2
            },
            new Prize
            {
                Name = "JACKS OR BETTER",
                Multiplier = 1
            }
        };
        decimal balance
        {
            get { return _balance; }
            set { _balance = value; labelDynamicBalance.Text = _balance.ToString("c"); }
        }
        decimal bet
        {
            get { return _bet; }
            set {
                _bet = value;
                labelDynamicBet.Text = _bet.ToString("N");
                var n = listViewPrizes.Items.Cast<ListViewItem>().Select(r => r.SubItems).SelectMany(q => q.Cast<ListViewItem.ListViewSubItem>());
                foreach (var b in n)
                {
                    b.BackColor = Color.MidnightBlue;
                }
                foreach (ListViewItem it in listViewPrizes.Items)
                {
                    var b = Convert.ToInt32(_bet / 10);
                    it.SubItems[b].BackColor = Color.Red;
                }
            }
        }
        public GameBoard()
        {
            InitializeComponent();
            balance = 12000;
            _deckofcards = new Deck();
            _kbd.KeyUp += _kbd_KeyUp;
        }
        private void GameBoard_Load(object sender, EventArgs e)
        {
            _kbd.Install();
            cardHand1.HandComplete += CardHand1_HandComplete;
            cardHand1.StartOfHand += CardHand1_StartOfHand;
            cardHand1.HandDealt += CardHand1_HandDealt;
            foreach (Prize p in Prizes)
            {
                var b = new ListViewItem(p.Name) {
                    Tag = $"_m{p.Name.Replace(" ","")}",
                    UseItemStyleForSubItems = false
                };
                b.SubItems.Add(string.Format("{0:C0}", (p.Multiplier * 10)), Color.White, Color.Red, null);
                b.SubItems.Add(string.Format("{0:C0}", (p.Multiplier * 20)));
                b.SubItems.Add(string.Format("{0:C0}", (p.Multiplier * 30)));
                b.SubItems.Add(string.Format("{0:C0}", (p.Multiplier * 40)));
                b.SubItems.Add(string.Format("{0:C0}", (p.Multiplier * 50)));
                listViewPrizes.Items.Add(b);
            }
        }
        private void _kbd_KeyUp(KeyboardHook.VKeys key)
        {
            if (ActiveForm == this)
            {
                switch (key)
                {
                    case KeyboardHook.VKeys.RETURN:
                        if (!cardHand1.IsInitialized)
                        {
                            cardHand1.Initialize(_deckofcards);
                        }
                        else
                        {
                            cardHand1.Deal();
                        }
                        break;
                    case KeyboardHook.VKeys.F1:
                        if (!cardHand1.IsInitialized || cardHand1.EndStage)
                            bet = 10M;
                        break;
                    case KeyboardHook.VKeys.F2:
                        if (!cardHand1.IsInitialized || cardHand1.EndStage)
                            bet = 20M;
                        break;
                    case KeyboardHook.VKeys.F3:
                        if (!cardHand1.IsInitialized || cardHand1.EndStage)
                            bet = 30M;
                        break;
                    case KeyboardHook.VKeys.F4:
                        if (!cardHand1.IsInitialized || cardHand1.EndStage)
                            bet = 40M;
                        break;
                    case KeyboardHook.VKeys.F5:
                        if (!cardHand1.IsInitialized || cardHand1.EndStage)
                            bet = 50M;
                        break;
                    case KeyboardHook.VKeys.NUMPAD1:
                    case KeyboardHook.VKeys.KEY_1:
                        cardHand1.HoldCard(1);
                        break;
                    case KeyboardHook.VKeys.NUMPAD2:
                    case KeyboardHook.VKeys.KEY_2:
                        cardHand1.HoldCard(2);
                        break;
                    case KeyboardHook.VKeys.NUMPAD3:
                    case KeyboardHook.VKeys.KEY_3:
                        cardHand1.HoldCard(3);
                        break;
                    case KeyboardHook.VKeys.NUMPAD4:
                    case KeyboardHook.VKeys.KEY_4:
                        cardHand1.HoldCard(4);
                        break;
                    case KeyboardHook.VKeys.NUMPAD5:
                    case KeyboardHook.VKeys.KEY_5:
                        cardHand1.HoldCard(5);
                        break;
                }
            }
        }
        private void CardHand1_HandDealt(object sender, EventArgs e)
        {
            // TODO: Do something with the dealt cards.
            // This was written for the DeckPeek form.
            // After card is dealt, you can communicate with the DeckPeek form
            // to set the card object of the return of the Peek().
        }
        private void CardHand1_StartOfHand(object sender, EventArgs e)
        {
            var p = listViewPrizes.Items.Cast<ListViewItem>();
            foreach (ListViewItem n in p)
            {
                n.ForeColor = Color.White;
            }
            labelDynamicResult.Text = string.Empty;
            labelDynamicWin.Text = "$0.00";
            // bet
            balance -= _bet;
        }
        private void CardHand1_HandComplete(object sender, CardHand.HandCompleteEventArgs e)
        {
            ListViewItem winnerPrize;
            //////////////////////////////
            ///   G A M E   L O G I C  ///
            //////////////////////////////
            Suit[] allSuits = e.Hand.Select(r => r.Suit).Distinct().ToArray();
            int[] seq = e.Hand.Select(r => r.Ordinal).ToArray().OrderBy(i => i).ToArray();
            var fourofakind = seq.GroupBy(f => f).Where(n => n.Count() == 4).Select(p => p.First()).ToArray();
            var threeofakind = seq.GroupBy(f => f).Where(n => n.Count() == 3).Select(p => p.First()).ToArray();
            var pairs = seq.GroupBy(f => f).Where(n => n.Count() == 2).Select(p => p.First()).ToArray();
            if (allSuits.Length == 1)
            {
                // suits the same, but ..
                if (seq.IsSequential())
                {
                    // is sequential, but ..
                    if (seq[0] == 10 && seq[4] == 14)
                    {
                        // ROYAL!
                        labelDynamicResult.Text = "ROYAL FLUSH";
                        labelDynamicWin.Text = (_bet * 800).ToString("c");
                        balance += _bet * 800;
                        winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mROYALFLUSH").FirstOrDefault();
                        winnerPrize.ForeColor = Color.Yellow;
                        return;
                    }
                    labelDynamicResult.Text = "STRAIGHT FLUSH";
                    winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mSTRAIGHTFLUSH").FirstOrDefault();
                    winnerPrize.ForeColor = Color.Yellow;
                    labelDynamicWin.Text = (_bet * 50).ToString("c");
                    balance += _bet * 50;
                    return;
                }
            }
            if (fourofakind.Length > 0)
            {
                if (fourofakind.Contains(2) || fourofakind.Contains(3) || fourofakind.Contains(4))
                {
                    labelDynamicResult.Text = "4 2s, 3s, 4s";
                    winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_m42s,3s,4s").FirstOrDefault();
                    winnerPrize.ForeColor = Color.Yellow;
                    labelDynamicWin.Text = (_bet * 40).ToString("c");
                    balance += _bet * 40;
                    return;
                }
                if (fourofakind.Contains(5) || fourofakind.Contains(6) || fourofakind.Contains(7) || fourofakind.Contains(8) || fourofakind.Contains(9) || fourofakind.Contains(10) || fourofakind.Contains(11) || fourofakind.Contains(12) || fourofakind.Contains(13))
                {
                    labelDynamicResult.Text = "4 5s THRU KINGS";
                    winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_m45sTHRUKINGS").FirstOrDefault();
                    winnerPrize.ForeColor = Color.Yellow;
                    labelDynamicWin.Text = (_bet * 25).ToString("c");
                    balance += _bet * 25;
                    return;
                }
            }
            if (threeofakind.Length > 0 && pairs.Length > 0)
            {
                labelDynamicResult.Text = "FULL HOUSE";
                winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mFULLHOUSE").FirstOrDefault();
                winnerPrize.ForeColor = Color.Yellow;
                labelDynamicWin.Text = (_bet * 8).ToString("c");
                balance += _bet * 8;
                return;
            }
            if (allSuits.Length == 1 && !seq.IsSequential())
            {
                labelDynamicResult.Text = "FLUSH";
                winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mFLUSH").FirstOrDefault();
                winnerPrize.ForeColor = Color.Yellow;
                labelDynamicWin.Text = (_bet * 5).ToString("c");
                balance += _bet * 5;
                return;
            }
            if (seq.IsSequential())
            {
                labelDynamicResult.Text = "STRAIGHT";
                winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mSTRAIGHT").FirstOrDefault();
                winnerPrize.ForeColor = Color.Yellow;
                labelDynamicWin.Text = (_bet * 4).ToString("c");
                balance += _bet * 4;
                return;
            }
            if (threeofakind.Length > 0)
            {
                labelDynamicResult.Text = "3 OF A KIND";
                winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_m3OFAKIND").FirstOrDefault();
                winnerPrize.ForeColor = Color.Yellow;
                labelDynamicWin.Text = (_bet * 3).ToString("c");
                balance += _bet * 3;
                return;
            }
            if (pairs.Length > 0)
            {
                if (pairs.Length == 2)
                {
                    labelDynamicResult.Text = "TWO PAIR";
                    winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mTWOPAIR").FirstOrDefault();
                    winnerPrize.ForeColor = Color.Yellow;
                    labelDynamicWin.Text = (_bet * 2).ToString("c");
                    balance += _bet * 2;
                    return;
                }
                else if (pairs.Length == 1)
                {
                    if (pairs.Contains(11) || pairs.Contains(12) || pairs.Contains(13) || pairs.Contains(14))
                    {
                        labelDynamicResult.Text = "JACKS OR BETTER";
                        winnerPrize = listViewPrizes.Items.Cast<ListViewItem>().Where(r => r.Tag.ToString() == "_mJACKSORBETTER").FirstOrDefault();
                        winnerPrize.ForeColor = Color.Yellow;
                        labelDynamicWin.Text = (_bet * 1).ToString("c");
                        balance += _bet * 1;
                        return;
                    }
                }
            }
            // no win.
            labelDynamicResult.Text = "PLAY AGAIN";
        }
        private void listViewPrizes_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            // Stop list from selecting any item. (Read-Only band-aid)
            if (e.IsSelected)
                e.Item.Selected = false;
        }
    }
}
