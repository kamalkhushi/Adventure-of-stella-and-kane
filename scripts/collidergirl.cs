using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class collidergirl : MonoBehaviour
{
    public Collider2D normalCollider;
    public Collider2D slideCollider;
    public girl girl;
    Vector2 offset = new Vector2(-0.53f, -0.07f);
    Vector2 zero = new Vector2(0, 0);
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //if (animator.GetCurrentAnimatorStateInfo(0).IsName("slideAnimation"))
        //{
        //    Debug.Log("afdad");
        //    slideCollider.enabled = true;
        //    normalCollider.enabled = false;
        //    Avoid any reload.
        //}
        /* if (Input.GetKey(KeyCode.S)&&boy.isrunning)
         {
             slideCollider.enabled = true;
             normalCollider.enabled = false;

             slideCollider.offset=offset ;

         }*/
        if ((CrossPlatformInputManager.GetButton("SlideButton")) || (Input.GetKey(KeyCode.S) && girl.isrunning))
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
