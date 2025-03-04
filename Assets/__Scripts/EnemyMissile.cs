using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    [SerializeField] private GameObject enemyMissilePrefab;
    [SerializeField] private float Ypadding = 0.5f;
    
    private float minX, maxX;

    
    void Start()
    {
        minX = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        maxX = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));

        float randomX = Random.Range(minX, maxX);
        float yValue == Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0)).y;

        Instantiate(enemyMissilePrefab, new Vector3(randomX, yValue + Ypadding, 0), Quaternion.identity)
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
        Move();

    }    
        
    public virtual void Move()
    {
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }    
        // transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        //if (transform.position == targetPosition)
        
          //  Destroy(gameObject);
       
    
       
}

