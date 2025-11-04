using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageTypeExample1 : MonoBehaviour
{
    [SerializeField] private DAMAGE_TYPE playerAttackType;
    [SerializeField] private DAMAGE_TYPE enemyResistance;
    [SerializeField] private DAMAGE_TYPE enemyWeakness;
    [SerializeField] private int baseDamage;

    // Start is called before the first frame update
    void Start()
    {
        switch (playerAttackType)
        {
            case DAMAGE_TYPE.SLASHING:
                baseDamage=DamegeType(playerAttackType, enemyResistance, enemyWeakness, baseDamage);
                break;

            case DAMAGE_TYPE.PIERCING:
                baseDamage = DamegeType(playerAttackType, enemyResistance, enemyWeakness, baseDamage);
                break;

            case DAMAGE_TYPE.BLUDGEONING:
                baseDamage = DamegeType(playerAttackType, enemyResistance, enemyWeakness, baseDamage);
                break;

            case DAMAGE_TYPE.MAGICAL:
                baseDamage = DamegeType(playerAttackType, enemyResistance, enemyWeakness, baseDamage);
                break;

            case DAMAGE_TYPE.FORCE:
                baseDamage = DamegeType(playerAttackType, enemyResistance, enemyWeakness, baseDamage);
                break;
        }
        Debug.Log("The final damage is " + baseDamage);
    }
    int DamegeType(DAMAGE_TYPE playerAttackType, DAMAGE_TYPE enemyResistance, DAMAGE_TYPE enemyWeaknessint, int baseDamage)
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
        return baseDamage;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
