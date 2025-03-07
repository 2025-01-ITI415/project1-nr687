using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMissileControl : MonoBehaviour
{
    private Vector3 target;
    [SerializeField] private float speed = 5f;
    void Start()
    {
        target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }

    // Update is called once per frame
    void Update()
    {
       transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
