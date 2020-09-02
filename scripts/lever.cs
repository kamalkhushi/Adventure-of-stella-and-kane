using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever : MonoBehaviour
{
    
    public GameObject player;
    public Behaviour[] behaviour; 
    


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < behaviour.Length; i++)
        {
            behaviour[i].enabled = false;
        }
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        
            if (player == null)
            {
                return;
            }
            if (player.transform.position.x > transform.position.x)
            {
                transform.localScale = new Vector3(1, 1, 1);
            }
            else if (player.transform.position.x < transform.position.x)
            {
                transform.localScale = new Vector3(-1, 1, 1);
            }
        if (transform.localScale.x == 1)
        {
            for (int i = 0; i < behaviour.Length; i++)
            {
                behaviour[i].enabled = false;
            }
        }
        if (transform.localScale.x == -1)
        {
            for (int i = 0; i < behaviour.Length; i++)
            {
                behaviour[i].enabled = true;
            }
        }
    }
}
