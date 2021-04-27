using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerWindow : MonoBehaviour
{
    [SerializeField] private GameObject _playerWindow;

    private void Start()
    {
        _playerWindow.SetActive(false);
        ServiceManager.Instance.InputController.CharacterWindowClicked += ChangeWindowState;
    }
    public void InitComponents()
    {
        _playerWindow.SetActive(false);
        ServiceManager.Instance.InputController.CharacterWindowClicked += ChangeWindowState;
    }
        
        
   public void ChangeWindowState()
    {
        _playerWindow.SetActive(!_playerWindow.activeInHierarchy);
    }
    private void OnDestroy()
    {
        ServiceManager.Instance.InputController.CharacterWindowClicked -= ChangeWindowState;
    }
}
