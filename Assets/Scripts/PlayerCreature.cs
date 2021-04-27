using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCreature : LivingCreature
{
    [SerializeField] PlayerInventoryUI _playerInventoryUI;
    public PlayerInventoryUI PlayerInventoryUI => _playerInventoryUI;
   public PlayerInventoryController PlayerInventoryController { get; private set; }
    protected override void Start()
    {
        base.Start();
        ActionController = new PlayerActionController(this);
        _playerInventoryUI.InitComponents();
        PlayerInventoryController = new PlayerInventoryController(this);
    }
}
