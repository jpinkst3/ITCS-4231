using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spawner : MonoBehaviour
{
    private float nextSpawnTime;
    [SerializeField] private GameObject Boom_Box;
    [SerializeField] private Countdown Timer;
    [SerializeField] private float delay = 12;

    private void Update()
    {
        if(ShouldSpawn())
        {
            Spawn();
        }
    }

    private void Spawn()
    {
        nextSpawnTime = Time.time + delay;
        Instantiate(Boom_Box, transform.position, transform.rotation);
        Timer.Reset();
    }

    private bool ShouldSpawn()
    {
        return Time.time >= nextSpawnTime;
    }
}
