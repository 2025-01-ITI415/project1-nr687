using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MissileCommand : MonoBehaviour
    {
    static private MissileCommand S;
    public GameObject enemyMissilePrefab;
    public float      enemySpawnPerSecond = 3f;
    public float      enemyInsetDefault = 1.5f;

    void Awake() 
    {
        Invoke(nameof(SpawnEnemyMissile), 3f/ enemySpawnPerSecond);
    }

    public void SpawnEnemyMissile()
    {
        float enemyInset = enemyInsetDefault;

    }
   
   
    
    
   
}
