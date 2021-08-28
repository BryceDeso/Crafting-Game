using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHitBoxBehavior : MonoBehaviour
{
    public GameObject enemy;
    public bool isHit = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("GroundEnemy"))
        {
            isHit = true;
            enemy = other.gameObject;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        isHit = false;
        enemy = null;
    }
}
