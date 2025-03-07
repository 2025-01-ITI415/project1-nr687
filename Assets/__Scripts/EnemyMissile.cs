using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    [SerializeField] private GameObject enemyMissilePrefab;
    [SerializeField] public float speed = 5f;

    private float minX, maxX;

    

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

        transform.position = Vector3.MoveTowards(transform.position, pos, speed * Time.deltaTime);

        if (transform.position == pos)
        {
            Destroy(gameObject);
        }

   
    }
    public virtual void Move()
    { // c
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }
}

