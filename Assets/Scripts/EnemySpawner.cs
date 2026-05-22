using System.Runtime.CompilerServices;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    [SerializeField] Enemy basicEnemy;

    [SerializeField] EnemyPath path;


    private void Start()
    {
       var spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
        spawnedEnemy.SetPath(path);

        spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
        spawnedEnemy.SetPath(path);

        spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
        spawnedEnemy.SetPath(path);

        spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
        spawnedEnemy.SetPath(path);

        spawnedEnemy = Instantiate(basicEnemy, transform.position, Quaternion.identity);
        spawnedEnemy.SetPath(path);
    }


    private void Update()
    {
        
    }



}
