using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DAMAGE_TYPE
{
    SLASHING = 1,
    PIERCING = 2,
    BLUDGEONING = 3,
    MAGICAL = 4,
    FORCE = 5
}
public class DamageTypeExample : MonoBehaviour
{
    [SerializeField] private DAMAGE_TYPE playerAttackType;
    [SerializeField] private DAMAGE_TYPE enemyResistance;
    [SerializeField] private DAMAGE_TYPE enemyWeakness;
    [SerializeField] private int baseDamage;

    // Start is called before the first frame update
    void Start()
    {
        if (playerAttackType == enemyResistance)
        {
            baseDamage = baseDamage / 2;
            Debug.Log("The enemy is resistant to " + playerAttackType);
            Debug.Log("Base Damage halved");
        }
        else if (playerAttackType == enemyWeakness)
        {
            baseDamage = baseDamage * 2;
            Debug.Log("The enemy is weak to " + playerAttackType);
            Debug.Log("Base Damage is doubled");
        }
        Debug.Log("The final damage is " + baseDamage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
