using System;
using System.Collections.Generic;
using System.Text;

namespace LightSeekerDeckBuilder.Data.Enums
{
    public enum OrderType
    {
        Astral,
        Dread,
        Mountain,
        Nature,
        Storm,
        Tech,
        Unaligned,
        Mixed
    }

    #region Order Types

    public enum ElementType
    {
        Gravity,
        Lunar,
        Solar,
        Death,
        Poison,
        Shadow,
        Crystal,
        Earth,
        Fire,
        Animal,
        Forest,
        Soul,
        Air,
        Lightning,
        Water,
        Explosives,
        Mechanical,
        Time,
        SuperiorGravity,
        SuperiorLunar,
        SuperiorSolar,
        SuperiorDeath,
        SuperiorPoison,
        SuperiorShadow,
        SuperiorCrystal,
        SuperiorEarth,
        SuperiorFire,
        SuperiorAnimal,
        SuperiorForest,
        SuperiorSoul,
        SuperiorAir,
        SuperiorLightning,
        SuperiorWater,
        SuperiorExplosives,
        SuperiorMechanical,
        SuperiorTime
    }

    #endregion

    public enum Wave
    {
        Awakening,
        Mythical
    }

    public enum Category
    {
        Action,
        Combo,
        Hero
    }

    public enum CardType
    {
        Attack,
        Buff,
        Defend,
        Item,
        ComboAttack,
        ComboBuff,
        ComboDefend,
        Hero
    }

    public enum Deck
    {
        StormIntro,
        TechIntro,
        AstralStarter,
        DreadStarter,
        MountainStarter,
        NatureStarter,
        StormStarter,
        TechStarter
    }

    public enum Rarity
    {
        Common,
        Uncommon,
        Rare,
        Mythic
    }
}
