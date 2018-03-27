using System;
using System.Collections.Generic;
using System.Text;
using LightSeekerDeckBuilder.Data.Enums;

namespace LightSeekerDeckBuilder.Data.Models
{
    public class Card
    {
        public int Id { get; set; }                             // e.g. 111
        public string Name { get; set; }                        // e.g. "Sun Strike"
        public CardType Type { get; set; }                      // e.g. ComboAttack
        public OrderType Order { get; set; }                    // e.g. Astral
        public List<ElementType> ElementTypes { get; set; }     // e.g. { Solar, Gravity }
        public Rarity CardRarity { get; set; }                  // e.g. Common
        public Wave CardWave { get; set; }                      // e.g. Awakening
        public string ImagePath { get; set; }                   // e.g. "../images/Cards/Astral/Combo/Attack/Sun_Strike.png"
        public string WikiLink { get; set; }                    // e.g. "https://www.lightseekers.cards/wiki/Sun_Strike"

        public Card(int id, string name, CardType type, OrderType order, List<ElementType> elementTypes, Rarity rarity, Wave cardWave, string imagePath, string wikiLink)
        {
            Id = id;
            Name = name;
            Type = type;
            Order = order;
            ElementTypes = elementTypes;
            CardRarity = rarity;
            CardWave = cardWave;
            ImagePath = imagePath;
            WikiLink = wikiLink;
        }
    }
}
