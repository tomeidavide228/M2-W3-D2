using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LetsPlayWithArrays : MonoBehaviour
{
    [SerializeField] private int[] array=new int[10];
    [SerializeField] private int value;
    // Start is called before the first frame update
    void Start()
    {
        int index = Find(array, value);
        if (index!=(-1))
        {
            Debug.Log("Original array");
            for (int i = 0; i < array.Length; i++) 
            {
                Debug.Log(array[i]);
            }
            //PutToTheBack(array, index);
            //Debug.Log("Modified array");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Debug.Log(array[i]);
            //}
            //ShiftOnce(array);
            //Debug.Log("Modified array");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Debug.Log(array[i]);
            //}
            ShiftTimes(array, value);
            Debug.Log("Modified array");
            for (int i = 0; i < array.Length; i++)
            {
                Debug.Log(array[i]);
            }

        }
    }

    int Find(int[] array, int value) 
    {
        for (int i = 0; i < array.Length; i++) 
        {
            if(array[i] == value)
            {
                return i;
            }
        }
        Debug.LogWarning("Value not found");
        return -1;
    }

    void PutToTheBack(int[] array, int index)
    {
        int cont=array[index];
        for (int i = index; i < array.Length; i++)
        {
            if(i == (array.Length - 1)) 
            {
                array[i] = cont;
            }
            else
            {
                array[i] = array[i + 1];
            }
        }
    }

    void ShiftOnce(int[] array)
    {
        int cont1= array[0];
        int cont2;
        for (int i = 0; i < array.Length; i++)
        {
            if (i == (array.Length-1))
            {
                array[0] = cont1;   
            }
            else
            {
                cont2 = array[i + 1];
                array[i + 1] = cont1;
                cont1 = cont2;
            }
        }
    }

    void ShiftTimes(int[] array, int times) 
    {
        for (int i = 0; i <= times; i++) 
        {
            ShiftOnce(array);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
