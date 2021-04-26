using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public enum ItemId
    {
        Gold = 1,
        Scrap = 2,
        Shard = 3,
        HP_Potion = 4,
        MP_Potion = 5,
        Emerald = 6,
        SoldierSword = 7,
    }
    public enum StatType
    {
        Default = 0,
        HP = 1,
        MP = 2,
        Agility = 3,
        Strengh = 4,
        Intelligence = 5,
        Defence = 6,
        Damage = 7,
        AtdckSpeed = 8,
    }
    public enum InreacserType
    {
        Value,
        Percent,
    }
    public enum EquipmentType
    {
        Weapon,
        Shilder,
        Helmet,
        Chest,
        Shoulders,
        Leggins,
        Boots,
        Belt,
        Ring,
        Medal,
        Amulet,
        Rune,
    }
    public enum RarityLvlType
    {
        Common = 0,
        Uncommon = 1,
        Megical = 2,
        Rare = 3,
        Epic = 4,
        Legendary = 5,
    }
    public enum ComponentType
    {
        QuaterComponent,
        HalfComponent,
        HoleComponent,
    }
}
