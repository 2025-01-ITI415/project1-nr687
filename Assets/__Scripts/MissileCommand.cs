using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCommand : MonoBehaviour
{
    static private MissileCommand S;
    public GameObject enemyMissilePrefab;
    public float      enemySpawnPerSecond = 3f;
    public float      enemyInsetDefault = 1.5f;

    void Awake() 
    {
        S = this;
        Invoke(nameof(SpawnEnemyMissile), 3f/enemySpawnPerSecond);
    }

    public void SpawnEnemyMissile()
    {
        int ndx = Random.Range(0, enemyMissilePrefab.Length);
        GameObject go = Instantiate<GameObject>(enemyMissilePrefab[ ndx ]);

        float enemyInset = enemyInsetDefault;

    }
    void Start()
    {
        InvokeRepeating("SpawnEnemyMissile", 1f, 2f);
    }

   
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                FirePlayerMissile(hit.point);
            }
        }
    }

    void SpawnEnemyMissile()
    {
        Vector3 spawnPosition = new Vector3(Random.Range(-20, 20f), 20f, Random.Range(-20f, 20f));
        Instantiate(enemyMissilePrefab, spawnPosition, Quaternion.identity);
    }
    void FirePlayerMissile(Vector3 targetPosition)
    {
        GameObject missile = Instantiate(playermissilePrefab, playerBase.position, Quaternion.identity);
        missile.GetComponent<PlayerMissile>().SetTarget(targetPosition);

    }
}
