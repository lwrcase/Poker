namespace Poker
{
    /// <summary>
    /// Deck interface.
    /// </summary>
    public interface IDeck
    {
        /// <summary>
        /// Number of cards left in queue.
        /// </summary>
        int CardsInQueue { get; }
        /// <summary>
        /// Gets the next card in the queue.
        /// </summary>
        /// <returns>Card object.</returns>
        Card GetNextCard();
        /// <summary>
        /// Peeks the next card in the queue without dequeuing.
        /// </summary>
        /// <returns>Card object.</returns>
        Card Peek();
        /// <summary>
        /// Clears deck, adds new card objects, and shuffles the deck.
        /// </summary>
        void NewDeck();
    }
}
