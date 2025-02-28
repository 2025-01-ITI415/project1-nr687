using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
    static public Transform PROJECTILE_ANCHOR;

    [Header("Set Dynamically")]
    [SerializeField]
    public GameObject collar;
    public float lastShotTime; // Time last shot was fired
    private Renderer collarRend;
    // Start is called before the first frame update
    private void Start()
    {
        {
            // Set up PROJECTILE_ANCHOR if it has not already been done
            if (PROJECTILE_ANCHOR == null)
            {                                       // b
                GameObject go = new GameObject("_ProjectileAnchor");
                PROJECTILE_ANCHOR = go.transform;
            }                                                
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
