using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class EnemyMissile : MonoBehaviour
{
    
    public float speed = 5f;
    private Vector3 targetPosition;


    
    void Start()
    {
        targetPosition = new Vector3(Random.Range(-10f, 10f), 0, Random.Range(-10f, 10f));
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
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
    public virtual void Move();
       
}

