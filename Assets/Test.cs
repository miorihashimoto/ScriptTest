using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss
{
   private int mp=53;

    public void Magic()
    {
        Debug.Log( "のダメージを与えた");
    }
    public void Defence(int damage)
    {
        Debug.Log(""+damage + "のダメージを受けた");
        this.mp -= (damage);
    }
}

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 2, 7, 3, 11, 9 };

        for (int a=0;a<array.Length;a++)
        {
            Debug.Log(array[a]);
        }
        for (int b=array.Length-1; b>=0; b--)
        {
            Debug.Log(array[b]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

