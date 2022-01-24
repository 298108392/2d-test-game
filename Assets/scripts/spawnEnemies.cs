using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    public GameObject enemy; //Objektet som ska spawnas
    private float spawnTime; //Tid mellan varje spawn
    private float spawnStartTime; //Tid innan första spawn
    public Transform[] spawnPoints; //Positionen där fienden spawnas

    // Start is called before the first frame update
    void Start()
    {
        spawnStartTime = 2f;
        spawnTime = 1f;
        InvokeRepeating("Spawn", spawnStartTime, spawnTime);
    }
    void Spawn()
    {
        //Skapar en instans av prefaben enemy vid spawn positionen och rotation.
        //Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
        int spawnPointsIndex = Random.Range(0, spawnPoints.Length);
        Instantiate(enemy, spawnPoints[spawnPointsIndex].position, spawnPoints[spawnPointsIndex].rotation);
    }
    void Despawn()
    {
        if (transform.position.x > 10)
        {
            gameObject.SetActive(false);
        }
        else if (transform.position.y > 10)
        {
            gameObject.SetActive(false);
        }
    }
}