using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class coliderchange : MonoBehaviour
{   
    public Collider2D normalCollider;
    public Collider2D slideCollider;
    public boy boy;
    Vector2 offset = new Vector2(0, -0.07f);
    Vector2 zero = new Vector2(0, 0);
    public Animator animator;
    void Start()
    {

    }
    void Update()
    {
    
        if (((CrossPlatformInputManager.GetButton("SlideButton"))|| (Input.GetKey(KeyCode.S)) && boy.isrunning))
        {
            slideCollider.enabled = true;
            normalCollider.enabled = false;
            slideCollider.offset = offset;
        }
        else
        {
            slideCollider.enabled = false;
            normalCollider.enabled = true;
            slideCollider.offset = zero;
        }
        
    }
}
