# Poker
A simple Poker game written in C# .NET. All card images are free to use and redistribute. This project includes a custom Card Hand
user control that is used to handle all interactions with the `Deck` and `Card` objects. It also includes a custom Card Panel
user control that handles displaying `Card` objects and animations.

## Interfaces
Interfaces that implement basic functionality of their classes.
### `IDeck`
The IDeck interface defines basic property and method signatures for a card Deck object.
#### `CardsInQueue` (Int32 Property)
Returns the number of cards left in the queue.
#### `GetNextCard` (Method)
Gets the next card in the queue. Returns `Card` object.
#### `Peek` (Method)
Peeks the next card in the queue without dequeuing the `Card` object. Returns `Card` object. 
#### `NewDeck` (Method)
Clears the List of Cards, adds new `Card` objects to the `List`, and shuffles the deck. Returns `void`.

## Controllers
Controllers that inherit their base Interfaces to implement Interface methods and properties.
### Deck
The Deck class implements IDeck interface properties and methods.
#### `List<Card>` : _cards
A private list that holds all of the cards in the deck.
#### `Queue<Card>` : Cards
A private queue that uses List<Card> _cards to handle queueing and dequeueing of Card objects from the deck.
#### Constructor: `Deck`
The constructor takes `0` arguments. A new `Deck` object will set `_cards` to a new `List<Card>` object and 
populate it using the private `GenerateAllCards` method. After populating the `_cards` object, it will call the `Shuffle`
custom extension for `List<T>` to shuffle the cards. After shuffling, it will set the `Cards` property to a new `Queue<Card>`
object containing elements from `_cards`.
#### `GenerateAllCards` (Method)
Generates a 52 card list of `Card` objects. Returns `List<Card>`.

## Models
Data model classes that are used throughout the application.
### Card (Class)
The card class defines properties and methods of an individual `Card` in play.
#### `string`: Name \[`getter`,`setter`\]
Display name of the `Card` object.
#### `Int32`: Ordinal \[`getter`,`setter`\]
Ordinal of the `Card` object. 2-14, 2 = 2, 14 = Ace. For use in determining sequential order of `Card` objects.
#### `Suit`: Suit \[`getter`,`setter`\]
Suit of the `Card` object.
#### `Image` Image \[`getter`,`setter`\]
Image resource to display for the card face.
#### `Boolean`: Held \[`getter`\]
Returns private `bool _held`. Reports card hold status.
#### `Hold` (Method): `[bool? hold = null]`
Sets the hold status. If `hold` argument is specified, sets private `_held` property to `hold` argument value. If no
`hold` argument is specified, it will toggle the value of private `_held` property.
