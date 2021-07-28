using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmorBehavior : MonoBehaviour
{
    public float armorPoints;

    public bool equipped;

    public string _name;

    [SerializeField]
    private GameObject _activeObject;

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
            _activeObject.SetActive(false);
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;
        }
        else if (equipped == false)
        {
            _activeObject.SetActive(true);
            gameObject.GetComponent<Rigidbody>().useGravity = true;
            gameObject.GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        }
    }
}
