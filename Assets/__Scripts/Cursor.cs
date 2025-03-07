using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] GameObject playerMissilePrefab;
    [SerializeField] GameObject canonPrefab;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(playerMissilePrefab, canonPrefab.transform.position, Quaternion.identity);
        }
    }
}
