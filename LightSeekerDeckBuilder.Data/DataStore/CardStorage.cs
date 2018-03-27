using System;
using System.Collections.Generic;
using System.Text;
using LightSeekerDeckBuilder.Data.Models;
using LightSeekerDeckBuilder.Data.Enums;

namespace LightSeekerDeckBuilder.Data.DataStore
{
    public static class CardStorage
    {
        public static List<Card> Library;

        public static void LoadData()
        {
            Library = new List<Card>();

            Library.Add(new Card(1, "Astral Priest", CardType.Attack, OrderType.Astral, new List<ElementType> { ElementType.Solar }, Rarity.Common, Wave.Awakening, @"\images\Cards\Astral\Action\Attack\Astral_Priest.png", @"https://www.lightseekers.cards/wiki/Astral_Priest"));
            Library.Add(new Card(2, "Chimchu Militantt", CardType.Attack, OrderType.Astral, new List<ElementType> { ElementType.Solar }, Rarity.Common, Wave.Awakening, @"\images\Cards\Astral\Action\Attack\Chimchu_Militant.png", @"https://www.lightseekers.cards/wiki/Chimchu_Militant"));
            Library.Add(new Card(3, "Mageship", CardType.Buff, OrderType.Astral, new List<ElementType> { ElementType.Solar }, Rarity.Common, Wave.Awakening, @"\images\Cards\Astral\Action\Buff\Mageship.png", @"https://www.lightseekers.cards/wiki/Mageship"));
            Library.Add(new Card(4, "Dawn Stalker", CardType.Buff, OrderType.Astral, new List<ElementType> { ElementType.Solar }, Rarity.Uncommon, Wave.Awakening, @"\images\Cards\Astral\Action\Buff\Dawn_Stalker.png", @"https://www.lightseekers.cards/wiki/Dawn_Stalker"));
            Library.Add(new Card(5, "Prismatic Sun Feeder", CardType.Attack, OrderType.Astral, new List<ElementType> { ElementType.Solar }, Rarity.Uncommon, Wave.Awakening, @"\images\Cards\Astral\Action\Attack\Prismatic_Sun_Feeder.png", @"https://www.lightseekers.cards/wiki/Prismatic_Sun_Feeder"));
            Library.Add(new Card(6, "Sun Beacon", CardType.Defend, OrderType.Astral, new List<ElementType> { ElementType.Solar }, Rarity.Uncommon, Wave.Awakening, @"\images\Cards\Astral\Action\Defend\Sun_Beacon.png", @"https://www.lightseekers.cards/wiki/Sun_Beacon"));



            Library.Add(new Card(99, "Planetary Alignment", CardType.ComboAttack, OrderType.Astral, new List<ElementType> { ElementType.Solar, ElementType.Lunar, ElementType.Gravity }, Rarity.Common, Wave.Awakening, @"\images\Cards\Astral\Combo\Attack\Planetary_Alignment.png", @"https://www.lightseekers.cards/wiki/Planetary_Alignment"));
            Library.Add(new Card(101, "Eclipse", CardType.ComboDefend, OrderType.Astral, new List<ElementType> { ElementType.Lunar, ElementType.Lunar, ElementType.Solar }, Rarity.Uncommon, Wave.Awakening, @"\images\Cards\Astral\Combo\Defend\Eclipse.png", @"https://www.lightseekers.cards/wiki/Eclipse"));
            Library.Add(new Card(102, "Constella", CardType.Hero, OrderType.Astral, new List<ElementType> { ElementType.Solar, ElementType.Lunar, ElementType.Gravity }, Rarity.Uncommon, Wave.Awakening, @"\images\Cards\Astral\Hero\Constella.png", @"https://www.lightseekers.cards/wiki/Constella"));
            Library.Add(new Card(103, "Orion", CardType.Hero, OrderType.Astral, new List<ElementType> { ElementType.Solar, ElementType.Lunar, ElementType.Gravity }, Rarity.Rare, Wave.Awakening, @"\images\Cards\Astral\Hero\Orion.png", @"https://www.lightseekers.cards/wiki/Orion"));
        }
    }
}
