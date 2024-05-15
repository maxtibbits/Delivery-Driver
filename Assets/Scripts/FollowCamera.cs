using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/**
 * This camera script follows the player character's position
 * 
 */

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followTarget;
    private static int cameraDistance = -10;

    Vector3 cameraPosition = new Vector3 (0, 0, cameraDistance);

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = followTarget.transform.position + cameraPosition;
    }
}
