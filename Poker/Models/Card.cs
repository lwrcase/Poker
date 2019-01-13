using System.Drawing;

namespace Poker
{
    /// <summary>
    /// Card class.
    /// </summary>
    public class Card
    {
        /// <summary>
        /// Display name of card.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Ordinal 2-14, 2 = 2, 14 = Ace
        /// </summary>
        public int Ordinal { get; set; }
        /// <summary>
        /// Suit of the card.
        /// </summary>
        public Suit Suit { get; set; }
        /// <summary>
        /// Image resource to display for card face.
        /// </summary>
        public Image Image { get; set; }
        private bool _held;
        /// <summary>
        /// Card hold status.
        /// </summary>
        public bool Held
        {
            get { return _held; }
        }
        public Card() { }
        /// <summary>
        /// Toggles hold status.
        /// </summary>
        /// <param name="hold">Optional hold argument.</param>
        public void Hold(bool? hold = null)
        {
            _held = hold.HasValue ? hold.Value : !_held;
        }
    }
    /// <summary>
    /// Suit
    /// </summary>
    public enum Suit
    {
        Heart,
        Spade,
        Club,
        Diamond
    }
}
