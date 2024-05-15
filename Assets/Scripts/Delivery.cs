using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    Boolean packageGet;
    [SerializeField] float destroyTimeDelay = 0.5f;

    [SerializeField] Color32 hasPackageColor = new Color32(231,23,23,255);
    [SerializeField] Color32 noPackageColor = new Color32(212, 199, 199, 255);

    SpriteRenderer spriteRenderer;

    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

   

    private void OnTriggerEnter2D(Collider2D collidedObject)
    {
        if (collidedObject.CompareTag("Customer") && !packageGet)
        {
            Debug.Log("REEEEEEEEEEEEEEEEEEE");
        }

        if (collidedObject.CompareTag("Customer") && packageGet)
        {
            Debug.Log("Package Deliverrred");
            packageGet = false;
            spriteRenderer.color = noPackageColor;
        }

        if (collidedObject.CompareTag("Package") && !packageGet)
        {
            Debug.Log("Package get!");
            packageGet = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collidedObject.gameObject, destroyTimeDelay);
        }
        
     }
 
}
