using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUIBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior _player;

    [SerializeField]
    private Text iron;
    [SerializeField]
    private Text oakWood;
    [SerializeField]
    private Text weapon;
    [SerializeField]
    private Text pickaxe;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void UpdateUI()
    {
        iron.text = ("Iron held: " + _player._ironHeld);
    }

}
