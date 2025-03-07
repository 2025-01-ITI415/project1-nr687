using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    [SerializeField] private GameObject enemyMissilePrefab;
    
    private float minX, maxX;

    
    void Start()
    {
      
    }

    public Vector3 pos
    {                                                       // a
        get
        {
            return this.transform.position;
        }
        set
        {
            this.transform.position = value;
        }
    }



    void Update()
    {
    

    }    
        

        // transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //if (transform.position == targetPosition)
        
          //  Destroy(gameObject);
       
    
       
}

