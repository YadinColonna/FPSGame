using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Maneja coroutinas
public class Start2 : MonoBehaviour
{
    public int maxNumber = 100;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start2");

        //StartCoroutine(Method_1());
        //StartCoroutine(Method_2());

        StartCoroutine(IntroBattle("will"));
    }
    
    public IEnumerator Method_1()
    {
        for (int i=1; i<= maxNumber;i++)
        {
            Debug.Log("i: "+i);
            yield return null;
        }
    }

    public IEnumerator Method_2()
    {
        Debug.Log("Hola que tal");
        yield return new WaitForSeconds(2);
        Debug.Log("Soy genialo 3000");
        yield return new WaitForSeconds(2);
        Debug.Log("Soy un robot que te ayudara en programación");
        yield return new WaitForSeconds(5);
        Debug.Log("Bueno ya me voy, adios");
    }

    public IEnumerator IntroBattle(string playerName)
    {
        //Fade in background (3s)
        yield return new WaitForSeconds(3);
        //Mostrar texto de new battle (2s)
        yield return new WaitForSeconds(2);
        //Fade out all elements (3s)
        yield return new WaitForSeconds(3);
        //Init battle
    }
}
