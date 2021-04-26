
using UnityEngine;
using System;

namespace Items
{
    
    public abstract class ItemBase : ScriptableObject
    {
        [SerializeField] private ItemId _itemId;
        [SerializeField] private string _name;
        [SerializeField] private string _description;
        [SerializeField] private int _cost;
        [SerializeField] private int _stackCount;
        [SerializeField] private Sprite _inventoryIcon;
        public ItemId ItemId => _itemId;
        public string Name => _name;
        public string Description => _description;
        public int StackCount => _stackCount;
        public int Cost => _cost;
        public Sprite InventoryIcon => InventoryIcon;


    }
    [CreateAssetMenu(fileName = "Consuenable",menuName = "Item/Consuenables")]
    public class ConsuenableBase : ItemBase { }
    [CreateAssetMenu(fileName = "Readable", menuName = "Item/Readables")]
    public class ReadableBase : ItemBase
    {
        [SerializeField] private string _text;
        public string Text => _text;
    }
    [CreateAssetMenu(fileName = "Potion", menuName = "Item/Potions")]
    public class PotionBase : ItemBase
    {
        [SerializeField] private int _potiotLvl;
        public int PotionLvl => _potiotLvl;
    }
    public abstract class StatItemBase : ItemBase
    {
        [SerializeField] private int _requiredLvl;
        [SerializeField] private ItemStat[] _primaryStats;

        public int RequiredLvl => _requiredLvl;
        public ItemStat[] PrimaryStatas => _primaryStats;
    }
    [CreateAssetMenu(fileName = "EgpmentComponent", menuName = "Item/EgpmentComponents")]
    public class EgpmentComponentBase : StatItemBase
    {
        [SerializeField] private EquipmentType[] _allowedEquipmentType;
        [SerializeField] private ComponentType _componentType;

        public EquipmentType[] AllowedEquipmentTypes => _allowedEquipmentType;
        public ComponentType ComponentType => _componentType;
    }
    [Serializable]
    public class Stat
    {
        public StatType StatType;
        public int Amount;
    }
    [Serializable]
    public class ItemStat : Stat 
    {
        public InreacserType InreacserType;
    }
    [CreateAssetMenu(fileName = "Egpment", menuName = "Item/Egpments")]
    public class EquipmentBase : StatItemBase
    {
        [SerializeField] private Stat[] _requiredStats;
        [SerializeField] private EquipmentType _equipmentType;
        [SerializeField] private RarityLvlType _rarityLvl;
        [SerializeField] private ItemStat[] _additionalStats;

        public Stat[] RequiredStats => _requiredStats;
        public EquipmentType EquipmentType => _equipmentType;
        public RarityLvlType RarityLvl => _rarityLvl;
        public ItemStat[] AdditemStats => _additionalStats;
    }
  
}