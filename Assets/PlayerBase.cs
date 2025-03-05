using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBase : MonoBehaviour
{
    [Header (" Inscribed" )]
    static public Transform PROJECTILE_ANCHOR;
    public float nextShotTime; 
    public GameObject playerMissile;
    

    private GameObject weaponModel;
    private Transform shotPointTrans;

    void Start()
    {
  
    }

   
    void Update()
    {
        
    }
}
