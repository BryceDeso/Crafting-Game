using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField]
    private float _health;
    [SerializeField]
    private float _currentHealth;
    [SerializeField]
    private float _armor;
    [SerializeField]
    private bool canBeHit = true;


    public GameObject _helmet;
    public GameObject _chestplate;
    public GameObject _leggings;
    public GameObject _boots;
    public GameObject _currentWeapon;
    public WeaponBehavior _weapon;
    public PickaxeBehavior _pickaxe;
    [SerializeField]
    private float _pickaxeDamage;
    [SerializeField]
    private float _weaponDamage;

    [SerializeField]
    private GameObject _weaponAnchor;
    [SerializeField]
    private GameObject _pickaxeAnchor;

    [SerializeField]
    private PlayerHitBoxBehavior _hitbox;

    public InteractableFieldBehavior _interactionField;

    public float _ironHeld;
    public float _goldHeld;
    public float _oakWoodHeld;

    public float _invincibleTime;
    public float _timeLeft;

    // Start is called before the first frame update
    void Start()
    {
        _weapon = null;
        _pickaxe = null;
        _currentHealth = _health;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerActions();
    }

    private void PlayerActions()
    {
        TakeDamage();
        Interact();
        UpdateStats();
    }

    private void TakeDamage()
    {
        if(_hitbox.isHit == true && canBeHit == true)
        {
            if(_hitbox.enemy.CompareTag("GroundEnemy"))
            {
                float damageTaken = _hitbox.enemy.GetComponent<GroundEnemyAIBehavior>().damage - _armor;
                _currentHealth -= damageTaken;
                canBeHit = false;
            }
        }

        if(canBeHit == false)
        {
            Timer();
        }
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
        }
    }

    private void UpdateStats()
    {
        if(_pickaxe)
        {
            _pickaxeDamage = _pickaxe.miningDamage;
        }
        if(_weapon)
        { 
            _weaponDamage = _weapon.weaponDamage;
        }
    }

    private void Interact()
    {
        if (_interactionField.ore)
        {
            if (Input.GetButtonDown("Fire1") && _interactionField.ore.canCollect == true)
            {
                if (_pickaxe.miningDamage >= _interactionField.ore.currentHealth)
                {
                    _ironHeld += _interactionField.ore.currentHealth;
                }
                else
                {
                    _ironHeld += _pickaxe.miningDamage;
                }

                _interactionField.ore.currentHealth -= _pickaxe.miningDamage;
                Debug.Log("Hit ore");
            }
        }
        if (Input.GetButtonDown("Fire1") && _interactionField.groundEnemy)
        {
            _interactionField.groundEnemy.health -= _weapon.weaponDamage;
            Debug.Log("Hit ground enemy");
        }
        if (Input.GetButtonDown("Fire1") && _interactionField.weapon)
        {
            _weapon = _interactionField.weapon;
            Debug.Log("Equipped " + _interactionField.weapon);
            _weapon.equipped = true;
            _weapon.transform.rotation = _weaponAnchor.transform.rotation;
            _weapon.transform.position = _weaponAnchor.transform.position;
            _weapon.gameObject.transform.parent = _weaponAnchor.transform;
        }
        if (Input.GetButtonDown("Fire1") && _interactionField.pickaxe)
        {
            _pickaxe = _interactionField.pickaxe;
            Debug.Log("Equipped " + _interactionField.weapon);
            _pickaxe.equipped = true;
            _pickaxe.transform.rotation = _pickaxeAnchor.transform.rotation;
            _pickaxe.transform.position = _pickaxeAnchor.transform.position;
            _pickaxe.gameObject.transform.parent = _pickaxeAnchor.transform;
        }
    }

    private void Timer()
    {
        _timeLeft -= Time.deltaTime;

        if (_timeLeft <= 0)
        {
            canBeHit = true;
            _timeLeft = _invincibleTime;
        }
    }
}