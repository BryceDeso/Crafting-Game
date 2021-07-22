using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBehavior : MonoBehaviour
{
    public float armorPoints;

    public bool equipped;

    public string _name;

    public float _oakWoodNeeded;
    public float _ironNeeded;
    public float _goldNeeded;

    public bool _helmet;
    public bool _chestplate;
    public bool _leggings;
    public bool _boots;

    private void Start()
    {
        gameObject.name = _name;
    }

    // Update is called once per frame
    void Update()
    {
        Behavior();
    }

    private void Behavior()
    {
        if (equipped == true)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        else if (equipped == false)
        {
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
