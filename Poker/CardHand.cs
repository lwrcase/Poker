using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Poker
{
    public partial class CardHand : UserControl
    {
        private IDeck _deck;
        private List<Card> _hand = new List<Card>();
        private bool _isInitialized = false;
        /// <summary>
        /// Reports initialization status.
        /// </summary>
        public bool IsInitialized
        {
            get { return _isInitialized; }
        }
        private int _stage = 0;
        public bool EndStage
        {
            get { return _stage == 1; }
        }
        protected virtual void OnStartOfHand()
        {
            StartOfHand?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// Fires to signal start of a new hand.
        /// </summary>
        public event EventHandler StartOfHand;
        protected virtual void OnHandDealt()
        {
            HandDealt?.Invoke(this, EventArgs.Empty);
        }
        /// <summary>
        /// Fires to signal new hand dealt after all cards are assigned.
        /// </summary>
        public event EventHandler HandDealt;
        /// <summary>
        /// Returns busy state of all card panels.
        /// </summary>
        public bool IsBusy
        {
            get
            {
                return cardPanel1.IsBusy && cardPanel2.IsBusy && cardPanel3.IsBusy && cardPanel4.IsBusy && cardPanel5.IsBusy;
            }
        }
        protected virtual void OnHandComplete(HandCompleteEventArgs e)
        {
            HandComplete?.Invoke(this, e);
        }
        /// <summary>
        /// Fires when all holds have been handled a new cards have been dealt to replace non-held cards.
        /// </summary>
        public event EventHandler<HandCompleteEventArgs> HandComplete;
        public CardHand()
        {
            InitializeComponent();
        }
        private void CardHand_Load(object sender, EventArgs e)
        {
        }
        /// <summary>
        /// Sets references and deals a new hand to start game.
        /// </summary>
        /// <param name="deck">Deck</param>
        public void Initialize(IDeck deck)
        {
            _deck = deck;
            _hand.Clear();
            OnStartOfHand();
            for (int i = 0; i < 5; i++)
            {
                _hand.Add(_deck.GetNextCard());
                Control[] panels = Controls.Find($"cardPanel{i + 1}", true);
                if (panels.Length > 0)
                {
                    ((CardPanel)panels[0]).SetCardObject(_hand[i]);
                }
            }
            _isInitialized = true;
            OnHandDealt();
        }
        /// <summary>
        /// Deals a new hand or replaces non-held cards with new cards after start hand.
        /// </summary>
        public void Deal()
        {
            if (_isInitialized)
            {
                if (_stage == 0)
                {
                    _stage = 1;
                    if (_deck.CardsInQueue < 5)
                    {
                        _deck.NewDeck();
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        if (!_hand[i].Held)
                        {
                            _hand[i] = _deck.GetNextCard();
                            Control[] panels = Controls.Find($"cardPanel{i + 1}", true);
                            if (panels.Length > 0)
                            {
                                ((CardPanel)panels[0]).SetCardObject(_hand[i]);
                            }
                        }
                    }
                    OnHandDealt();
                    OnHandComplete(new HandCompleteEventArgs { Hand = _hand });
                }
                else
                {
                    OnStartOfHand();
                    _hand.Clear();
                    if (_deck.CardsInQueue < 5)
                    {
                        _deck.NewDeck();
                    }
                    // get 5 new cards
                    for (int i = 0; i < 5; i++)
                    {
                        _hand.Add(_deck.GetNextCard());
                        Control[] panels = Controls.Find($"cardPanel{i + 1}", true);
                        if (panels.Length > 0)
                        {
                            ((CardPanel)panels[0]).SetCardObject(_hand[i]);
                        }
                    }
                    OnHandDealt();
                    _stage = 0;
                }
            }
        }
        /// <summary>
        /// Holds a card in play.
        /// </summary>
        /// <param name="position"></param>
        public void HoldCard(int position)
        {
            if (_isInitialized && _stage == 0)
            {
                switch (position)
                {
                    case 1:
                        cardPanel1.CardHeld = !cardPanel1.CardHeld;
                        break;
                    case 2:
                        cardPanel2.CardHeld = !cardPanel2.CardHeld;
                        break;
                    case 3:
                        cardPanel3.CardHeld = !cardPanel3.CardHeld;
                        break;
                    case 4:
                        cardPanel4.CardHeld = !cardPanel4.CardHeld;
                        break;
                    case 5:
                        cardPanel5.CardHeld = !cardPanel5.CardHeld;
                        break;
                }
            }
        }
        /// <summary>
        /// Event arguments for Completed Hand events.
        /// </summary>
        public class HandCompleteEventArgs : EventArgs
        {
            /// <summary>
            /// List of Cards currently on display at the end of a completed hand.
            /// </summary>
            public List<Card> Hand { get; set; }
            public HandCompleteEventArgs() { }
        }
    }
}
