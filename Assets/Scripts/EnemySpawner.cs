using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] WaveEventSO enemyWave;

    [SerializeField] Enemy basicEnemy;

    [SerializeField] EnemyPath path;


    private void Start()
    {
        //StartCoroutine(spawnEnemy());

        StartCoroutine(ReleaseWave(enemyWave));
    }


    IEnumerator ReleaseWave(WaveEventSO waveToRelease)
    {
        yield return new WaitForSeconds(2);

        foreach(Enemy enemyToSpawn in waveToRelease.enemies)
        {
            var spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
            spawnedEnemy.SetPath(path);

            yield return new WaitForSeconds(2);
        }
    }


    IEnumerator spawnEnemy()
    {

        for (int i = 0; i < 10; i++)
        {
            var spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
            spawnedEnemy.SetPath(path);

            yield return new WaitForSeconds(2);
        }
        


    }
   


}
