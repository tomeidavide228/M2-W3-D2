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

                break;

            case DAMAGE_TYPE.PIERCING:


                break;

            case DAMAGE_TYPE.BLUDGEONING:


                break;

            case DAMAGE_TYPE.MAGICAL:


                break;
            case DAMAGE_TYPE.FORCE:

                break;
        }
        Debug.Log("The final damage is " + baseDamage);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
