using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum STATE
{
    IDLE = 1,
    AGGROED = 2,
    ATTACKING = 3,
    DEFEATED = 4
}
public class EnemySwitchBehaviour : MonoBehaviour
{
    [SerializeField] private STATE enemy;
    // Start is called before the first frame update
    void Start()
    {
        if (enemy == STATE.IDLE)
        {
            Debug.Log("The enemy is idle");
        }
        else if (enemy == STATE.AGGROED)
        {
            Debug.Log("The enemy chases the player");
        }
        else if (enemy == STATE.ATTACKING)
        {
            Debug.Log("The enemy attacks the player");
        }
        else if (enemy == STATE.DEFEATED)
        {
            Debug.Log("The enemy is defeated");
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
