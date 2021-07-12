using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]

public class WeaponBehavior : MonoBehaviour
{
    public float weaponDamage;

    public bool equipped;

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
