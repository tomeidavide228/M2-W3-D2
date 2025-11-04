using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariableSwap : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        int b = 8;
        //Exercise 1
        //int cont;
        //Debug.Log("A = " + a + " " + "B = " + b);
        //cont = b;
        //b = a;
        //a = cont;
        //Debug.Log("A = " + a + " " + "B = " + b);
        //Exercise 2
        Swap(a, b);
        Debug.Log("A = " + a + " " + "B = " + b);
        //In the frist swap the value of a and b are swapped only in the function.
        Swap(ref a, ref b);
        Debug.Log("A = " + a + " " + "B = " + b);
        //In the second swap the value of a and b are used by reference and then the original variable changes directly.
    }
    void Swap(int n, int m)
    {
        int cont = m;
        m = n;
        n = cont;
        Debug.Log(n);
        Debug.Log(m);
    }
    void Swap(ref int n, ref int m)
    {
        int cont = m;
        m = n;
        n = cont;
        Debug.Log(n);
        Debug.Log(m);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
