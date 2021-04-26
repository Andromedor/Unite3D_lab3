using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;
public class ItemInterectable : Interectable
{
   [SerializeField] private Itemm _thisItem;
    protected override void Interect()
    {
        base.Interect();
        //_thisItem.Destroy(_player);
    }
}
