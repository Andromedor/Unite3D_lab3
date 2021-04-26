using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Items
{
    public class Itemm
    {
        private ItemBase _itemBase;
        protected PlayerCreature _ownrer;
        public ItemId ItemId => _itemBase.ItemId;
        public int CurrentCost => _itemBase.Cost;
        public Sprite InventoryIcon => _itemBase.InventoryIcon;

        public int CurrentStackCount { get; protected set; }

        public Itemm(ItemBase itemBase)
        {
            _itemBase = itemBase;
        }

        public virtual void Use()
        {

        }
        public void SetOwner(PlayerCreature player)
        {
            _ownrer = player;
        }
        public void ReleaseItem()
        {
            _ownrer = null;
        }
    }
    public class Readable : Itemm
    {
        public ReadableBase ReadableBase { get; private set; }
        public Readable(ReadableBase itemBase): base(itemBase)
        {
            ReadableBase = itemBase;
        }
        public override void Use()
        {
            base.Use();
            Debug.Log("Reading text");
        }
    }
    public class Potion : Itemm 
    {
        public PotionBase PotionBase { get; private set; }
        public int RestorationAmount => PotionBase.PotionLvl * 250;
             public Potion(PotionBase itemBase) : base(itemBase)
        {
            PotionBase = itemBase;
        }
        public override void Use()
        {
            base.Use();
            Debug.Log("Restored" + RestorationAmount + "Stat");
        }
    }

    public class Egpment : Itemm
    {
        public EquipmentBase EquipmentBase { get; private set; }
        public Egpment(EquipmentBase itemBase) : base(itemBase)
        {
            EquipmentBase = itemBase;
        }
        public override void Use()
        {
            base.Use();
            Debug.Log("Egpment");
        }
    }
    public class EquipmentComponent : Itemm
    {
        public EgpmentComponentBase EquipmentBase { get; private set; }
        public EquipmentComponent(EgpmentComponentBase itemBase) : base(itemBase)
        {
            EquipmentBase = itemBase;
        }
        public override void Use()
        {
            base.Use();
            Debug.Log("Start adding component to equipment");
        }
    }


}
