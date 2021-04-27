using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Items;
using UnityEngine.EventSystems;
public class PlayerInventoryController : MonoBehaviour
{
    private PlayerCreature _player;
   public PlayerInventoryController(PlayerCreature player)
    {
        _player = player;
    }
    public  bool AddItemToInventory(Itemm item)
    {
        InventorySlot slot = _player.PlayerInventoryUI.GetFreeSlot();
        if (slot == null)
        {
            return false;
        }
        slot.AddItemToSlot(item);
       // slot.Righ
        return true;
    }

    public void OnItemUsed(ItemSlot slot)
    {
        //if (slot.SlotItem.Use())
        //{
        //    slot.RemoveItem();
        //}
    }
}
