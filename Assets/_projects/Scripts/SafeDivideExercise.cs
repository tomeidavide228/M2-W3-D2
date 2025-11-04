using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeDivideExercise : MonoBehaviour
{

    [SerializeField] private int dividend;
    [SerializeField] private int divisor;
    // Start is called before the first frame update
    void Start()
    {
        int result=0;
        if (SafeDivide(dividend, divisor, out result) == true)
        {
            Debug.Log("The result is " + result);
        }
        else 
        {
            Debug.Log("The divisor it can't be " + result);
        }
    }

    bool SafeDivide(int dividend, int divisor, out int result)
    {
        if (divisor == 0)
        {
            result = 0;
            return false;
        }
        else
        {
            result = dividend / divisor;
            return true;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
