# Lightseeker Deck Builder
The purpose of this project is to create a simple Deck Building tool for the trading card game "Lightseekers".

Current Technologies:
* .NET Core
* MVC Framework
* jQuery
* Bootstrap v3.3.7

Currently the app has no stored back-end and is all managed in memory, this may or may not change depending on the card library.
This makes the most sense for now since there's a managable amount of cards and no need for costly data transactions to a DB.

Decks currently won't be stored in a database either and will instead be "saved" via a URL that saves the IDs created in the deck. This URL is read, parsed, and properly displayed on the page (well, it will once I write that feature). This is all mainly so I don't have to deal with SQL Server hosting as well when I deploy this.

Current Features:
* Select cards, add them too your "deck".
* Keep track of counts and meta-data in the background.

In Progress Features (No Particular Order): 
* "Save" feature via URL generation.
* Load the rest of the cards into the DataStore.
* Make it not look *totally* generic bootstrap looking.
* Limit cards able to be added to what the ruleset calls for (3 for actions, 1 for hero, 1 for combos).
* Add ability to remove cards from deck.
* Hover over card in deck to see preview of card.
* Details pane to open up and view the full details of a card with a link to the Wiki page.
* Basic stats on your deck (ex. How many of each element is currently in your deck?).
* Find out how to fit this all on the page properly.

Planned Features (Not currently being worked on):
* More advanced stats (ex. Estimates on how much potential damage your deck could do).
* Share buttons.
* Drag and drop? (Probably not)

All images and card data are found on the official Lightseekers Card Wiki: https://www.lightseekers.cards/wiki/Main_Page
