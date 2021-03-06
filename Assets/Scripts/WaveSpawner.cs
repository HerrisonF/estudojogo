﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class WaveSpawner : MonoBehaviour
{
    public Transform enemyPrefab;

    public Transform spawnPoint;

    public Text waveCountdownTimer;

    public float timeBetweenWaves = 5f;
    private float countdown = 2f;

    private int waveNumber = 0;

    private void Update() {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timeBetweenWaves;
            timeBetweenWaves++;
        }

        countdown -= Time.deltaTime;

        updateCountdownTimer();
    }

    private void updateCountdownTimer() 
    {
        waveCountdownTimer.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave ()
    {
        waveNumber++;

        for (int i = 0; i < waveNumber; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
        }
    }

    private void SpawnEnemy() {
       Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}
