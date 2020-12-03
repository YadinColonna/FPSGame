using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavMeshBullet : MonoBehaviour
{
    public float damage = 1;
    public float mySpeed = 5;
    public Rigidbody myRigidbody;
    public GameObject deathSpawnObject;

    private Vector3 myDirection;

    public void Init(Vector3 direction)
    {
        myDirection = direction;
    }

    private void Update()
    {
        myRigidbody.velocity = myDirection * mySpeed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        vp_DamageHandler damageHandler = collision.transform.GetComponent<vp_DamageHandler>();
        //Checamos, que la bala haya chocado con cualquier cosa que tenga DamageHandler
        if (damageHandler != null)
        {
            damageHandler.Damage(damage);
        }

        GameObject.Instantiate(deathSpawnObject, this.transform.position, this.transform.rotation);
        Destroy(this.gameObject);
    }
}
