using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawrotating : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float smooth = 5.0f;
    //float tiltAngle = 5f;

    void Update()
    {
        // Smoothly tilts a transform towards a target rotation.
        // float tiltAroundZ = Input.GetAxis("Horizontal") * tiltAngle;
        //float tiltAroundX = Input.GetAxis("Vertical") * tiltAngle;

        //Quaternion target = Quaternion.Euler(0, 0, tiltAroundZ);

        // Dampen towards the target rotation
        // transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime * smooth);
        transform.Rotate (0, 0, smooth);
    }
}
