using System;
using UnityEngine;
using Random = UnityEngine.Random;

public class CarSpawner : MonoBehaviour
{
    public float spawnDelay = .3f;

    private float nextTimeToSpawn = 0f;

    //private float despawnTimer = Time.deltaTime;

    public GameObject car;

    public Transform[] spawnPoints;

    //Spawns an item (in this case a car) after a certain amount of time.
    //private float countDownTimer = 3f;

    //The Start does the same thing as Update.
    //private void Start()
    //{
    //    InvokeRepeating("SpawnCar", 0f, 3f);
    //}

    //Look up Destroying Object after certain amount of time passes.
    //private void Start()
    //{
    //    Destroy(car, 5);
    //}

    void Update()
    {
        //If the count down timer reaches 0 run the command.
        //if (countDownTimer <= 0f)
        //{
        //    SpawnCar();
        //    Reset the timer delay.
        //    countDownTimer = 3f;

        //}
        //else
        //{
        //    countDownTimer -= Time.deltaTime;
        //}

        if (nextTimeToSpawn <= Time.time)
        {
            SpawnCar();
            nextTimeToSpawn = Time.time + spawnDelay;
        }
    }

    void SpawnCar()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }
}

