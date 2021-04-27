using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Items;
using UnityEngine.EventSystems;
public class ItemSlot : MonoBehaviour, IPointerClickHandler
{
    
    [SerializeField] private Image _slotImage;
    public bool IsEquiped { get; private set; }
    public Itemm SlotItem { get; private set; }
    public bool SlotInteractable { get; protected set; }
    public PlayerCreature PlayerCreature { get; set; }

    //public Action<ItemSlot> LeftPointerClicked = delegate { };
  // public Action<ItemSlot> RightPointerClicked = delegate { };
    public void AddItemToSlot(Itemm item)
    {
        if (IsEquiped)
            RemoveItem();
        SlotItem = item;
        IsEquiped = true;
        _slotImage.sprite = item.InventoryIcon;
        _slotImage.color = Color.white;
          
    }

    public virtual void RemoveItem()
    {
        _slotImage.sprite = null;
        _slotImage.color = Color.clear;
        SlotItem = null;
        IsEquiped = false;
    }
    private void OnLeftClick()
    {
        Debug.Log("LeftClick");
    }
    private void OnRightClick()
    {
        Debug.Log("OnRightClick");
    }
    //public virtual void RemoveItem()
    //{
    //    _slotImage.sprite = null;
    //    _slotImage.color = Color.clear;
    //    SlotItem = null;
    //    IsEquiped = false;
    //}
    public void OnPointerClick(PointerEventData eventData)
    {
        if (eventData.button == PointerEventData.InputButton.Left)
            OnLeftClick();
        else if (eventData.button == PointerEventData.InputButton.Right)
            OnRightClick();
    }
}
