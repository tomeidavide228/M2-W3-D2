using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySwitchBehaviour1 : MonoBehaviour
{
    [SerializeField] private STATE enemy;
    // Start is called before the first frame update
    void Start()
    {
        switch (enemy)
        {
            case STATE.IDLE:

                Debug.Log("The enemy is idle");
                break;

            case STATE.AGGROED:

                Debug.Log("The enemy chases the player");
                break;

            case STATE.ATTACKING:

                Debug.Log("The enemy attacks the player");
                break;

            case STATE.DEFEATED:

                Debug.Log("The enemy is defeated");
                break;
        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
