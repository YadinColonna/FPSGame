using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshExample : MonoBehaviour
{
    public Transform target;
    public float attackRange = 5;
    public float visionRange = 7;

    public Transform bulletSpawnPoint;
    public GameObject bullet;

    private NavMeshAgent agent;
    private NavMeshExampleState myState;

    public float attackRate = 1;
    private float lastSpawnTime = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        myState = NavMeshExampleState.Following;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(this.transform.position, target.position);

        //Seleccionar estado actual
        if (distance <= attackRange)
        {
            myState = NavMeshExampleState.Attacking;

        } else if (distance > visionRange)
        {
            myState = NavMeshExampleState.Following;
        }

        //Implementando logica por estado
        if (myState == NavMeshExampleState.Following)
        {
            agent.isStopped = false;
        } else 
        if (myState == NavMeshExampleState.Attacking)
        {
            agent.isStopped = true;

            if (Time.time > lastSpawnTime + attackRate)
            {
                //Calcular la direccion del personaje a la esfera
                Vector3 direction = target.position - bulletSpawnPoint.position;
                //Normalizando direccion
                direction.Normalize();

                //Spawneo de la bala
                GameObject spawnedBullet = GameObject.Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
                //Ignore collisions
                Physics.IgnoreCollision(spawnedBullet.GetComponent<Collider>(), this.GetComponent<Collider>(), true);
                //Referencia a la bala spawneada
                NavMeshBullet bulletRef = spawnedBullet.GetComponent<NavMeshBullet>();
                //Set direction
                bulletRef.Init(direction);

                lastSpawnTime = Time.time;
            }
        }

        agent.destination = target.position;
    }
}

public enum NavMeshExampleState
{
    Following,
    Attacking
}
