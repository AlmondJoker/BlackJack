# Blackjack Game

A simple Blackjack game implemented in C#. This project provides a basic understanding of card game mechanics, including shuffling and dealing cards, within a Windows Forms application.

## Description

This Blackjack game is built using Windows Forms and C#. It features a standard deck of cards, shuffling, and dealing mechanics. The game allows users to draw cards and calculate their values according to Blackjack rules. Players can hit, stand, and play against a dealer in this classic card game.

## Features

- Standard deck of cards with suits and values.
- Shuffle functionality to randomize the deck.
- Deal functionality to draw cards from the deck.
- Game logic for hitting, standing, and calculating hand values.
- Basic UI for interacting with the game.

## Installation

1. Clone the repository:
    ```sh
    git clone https://github.com/your-username/blackjack.git
    ```

2. Open the project in Visual Studio.

3. Build the project to restore dependencies and compile the code.

## Usage

1. Run the application from Visual Studio.
2. Use the provided UI to:
   - **Deal**: Start the game by dealing cards to the player and dealer.
   - **Hit**: Draw an additional card for the player.
   - **Stand**: End the player's turn and let the dealer draw cards until their hand value reaches at least 17.
   - **Leave**: Exit the game.

## Code Structure

### Deck.cs

This file contains the logic for creating and managing the deck of cards.

### Form1.cs

This file contains the logic for the game's main form, including event handlers for dealing cards, hitting, and standing.

## Contributing

Contributions are welcome! Please open an issue or submit a pull request for any changes.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
