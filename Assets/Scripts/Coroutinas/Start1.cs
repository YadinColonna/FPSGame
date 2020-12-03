using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start1 : MonoBehaviour
{
    public int maxNumber = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start1");

        Method_1();
    }

    public void Method_1()
    {
        for (int i = 1; i <= maxNumber; i++)
        {
            Debug.Log("i: " + i);
        }
    }

    public int Method_2()
    {
        return 0;
    }

    public void Method_3()
    {

    }

    public void Method_4()
    {

    }
}
