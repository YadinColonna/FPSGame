using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForce : MonoBehaviour
{
    public Vector3 forceDirection;
    public Rigidbody myRigidbody;

    private void Update()
    {
        myRigidbody.AddForce(forceDirection * Time.deltaTime);
    }
}
