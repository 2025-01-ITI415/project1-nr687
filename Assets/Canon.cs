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
        collar = transform.Find("Collar").gameObject;
        collarRend = collar.GetComponent<Renderer>();


        // Dynamically create an anchor for all Projectiles
        if (PROJECTILE_ANCHOR == null)
        {
            GameObject go = new GameObject("_ProjectileAnchor");
            PROJECTILE_ANCHOR = go.transform;
        }

        // Find the fireDelegate of the root GameObject
        GameObject rootGO = transform.root.gameObject;
        if (rootGO.GetComponent<Canon>() != null)
        {
            rootGO.GetComponent<Canon>().fireDelegate += Fire;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
