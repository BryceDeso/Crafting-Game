using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CraftingUI : MonoBehaviour
{
    [SerializeField]
    private GameObject _craftingUI;

    [SerializeField]
    private UIManagerBehavior _UIManager;

    private 

    private void Update()
    {
        Crafting();
    }

    public void Crafting()
    {
        if(Input.GetButtonDown("Fire1") && _UIManager._player._interactionField.canCraft == true)
        {
            _craftingUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
            Cursor.lockState = CursorLockMode.Confined;
        }
    }

    public void ExitCraftingMenu()
    {
        _craftingUI.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }
}
