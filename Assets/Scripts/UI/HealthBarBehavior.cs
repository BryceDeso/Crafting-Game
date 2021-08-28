using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBarBehavior : MonoBehaviour
{
    [SerializeField]
    private PlayerBehavior _player;

    [SerializeField]
    private Slider slider;

    private void Update()
    {
        UpdateHealth();
    }

    private void UpdateHealth()
    {
        slider.value = _player._currentHealth;
    }
}
