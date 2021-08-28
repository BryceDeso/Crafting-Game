using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class WeaponBehavior : MonoBehaviour
{
    public float weaponDamage;

    public bool equipped;

    public string _name;

    public float _oakWoodNeeded;
    public float _jungleWoodNeeded;
    public float _ashWoodNeeded;
    public float _ironNeeded;
    public float _goldNeeded;
    public float _silverNeeded;
    public float _diamondsNeeded;
    public float _bloodstoneNeeded;
    public float _chlorophyteNeeded;
    public float _mithrilNeeded;

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
        if(equipped == true)
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
