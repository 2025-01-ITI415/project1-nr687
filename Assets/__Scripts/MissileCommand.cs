using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileCommand : MonoBehaviour
{
    public GameObject enemyMissilePrefab;
    public GameObject playermissilePrefab;
    public Transform playerBase;
  

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
