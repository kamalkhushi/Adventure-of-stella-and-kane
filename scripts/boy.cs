using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.SceneManagement;


public class boy : MonoBehaviour
{
        Rigidbody2D boyRigidbody;
    [SerializeField] float runspeed = 5f;
    [SerializeField] float jumpspeed = 5f;
    public Animator myanimation;
    Collider2D myCollider;
    bool isDead = false;
    private uiManager ui;
    public bool isrunning;
    string sceneName;
    Scene m_Scene;
 

    void Start()
    {
        boyRigidbody = GetComponent<Rigidbody2D>();
        myanimation = GetComponent<Animator>();
        myCollider = GetComponent<Collider2D>();
        m_Scene = SceneManager.GetActiveScene();
        if (m_Scene.name == "level1")
        {
            ui = GameObject.FindGameObjectWithTag("manager").GetComponent<uiManager>();
        }
        


    }
    void Update()
    {
        
        if (boyRigidbody.velocity.x == 0)
        {
            isrunning = false;
        }
            myanimation.SetBool("slide", false);
        if (isDead == false)
        {
            run();
            spriteFlip();
            jump();
        }
        if (isDead)
        {
            if (myCollider.IsTouchingLayers(LayerMask.GetMask("ground")))
            {

                boyRigidbody.velocity = new Vector2(0, 0);
            }
        }
        handelLayers();
        if (boyRigidbody.velocity.y < 0)
        {
            myanimation.SetBool("land", true);
        }
        if ((CrossPlatformInputManager.GetButton("SlideButton")) || (Input.GetKeyDown(KeyCode.S)))
        {
            Debug.Log("lol");
            myanimation.SetBool("slide", true);
        }
      
    }
    private void run()
    {
        float controlthrow = CrossPlatformInputManager.GetAxis("Horizontal");
        Vector2 playervelocity = new Vector2(controlthrow * runspeed, boyRigidbody.velocity.y);
        boyRigidbody.velocity = playervelocity;
        bool playerhashorizontalspeed = Mathf.Abs(boyRigidbody.velocity.x) > Mathf.Epsilon;
        myanimation.SetBool("run", playerhashorizontalspeed);
        isrunning = true;
    }
    private void spriteFlip()
    {
        bool playerhashorizontalspeed = Mathf.Abs(boyRigidbody.velocity.x) > Mathf.Epsilon;
        if (playerhashorizontalspeed)
        {
            transform.localScale = new Vector2(Mathf.Sign(boyRigidbody.velocity.x), 1f);
        }
    }
    private void jump()
    {
        if (!myCollider.IsTouchingLayers(LayerMask.GetMask("ground")))
        {
            return;
        }
        else
        {
            myanimation.ResetTrigger("jump2");
            myanimation.SetBool("land", false);
        }
        if (CrossPlatformInputManager.GetButtonDown("Jump"))
        {
            myanimation.SetBool("jump2", true);
            Vector2 jumpVelocityToAdd = new Vector2(0f, jumpspeed);
            boyRigidbody.velocity += jumpVelocityToAdd;
        }
    }
    private void handelLayers()
    {
        if (!myCollider.IsTouchingLayers(LayerMask.GetMask("ground")))
        {
            myanimation.SetLayerWeight(1, 1);
        }
        else
        {
            myanimation.SetLayerWeight(1, 0);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "enemy")
        {
            isDead = true;
            myanimation.SetBool("Death", true);
        }
        if (collision.gameObject.tag == "coin")
        {
            Destroy(collision.gameObject);
            ui.coinIncrease();
        }
    }
}
