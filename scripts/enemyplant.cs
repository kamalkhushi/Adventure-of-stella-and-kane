using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyplant: MonoBehaviour
{
    //public GameObject[] enemyPlant;
     GameObject player;
    //public GameObject girl;
    //public GameObject enemyPlant;


    // Start is called before the first frame update
    void Start()
    {

        if (GameObject.FindGameObjectWithTag("Player").activeInHierarchy)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
    }

    // Update is called once per frame
    void Update()
    {


        if (player==null)
        {
            return;
        }
        if (player.transform.position.x > transform.position.x)
        {
            //face right
            transform.localScale = new Vector3(2, 2, 2);
        }
        else if (player.transform.position.x < transform.position.x)
        {
            //face left
            transform.localScale = new Vector3(-2, 2, 2);
        }
        /*if(player.transform.position.x > enemyPlant[0].transform.position.x)
       {
           Vector3 scale = enemyPlant[0].transform.localScale;
           scale.x = scale.x * -1;
           enemyPlant[0].transform.localScale = scale;
       }

      if (player.transform.position.x > enemyPlant[1].transform.position.x)
       {
           Vector3 scale = enemyPlant[1].transform.localScale;
           scale.x = scale.x * -1;
           enemyPlant[1].transform.localScale = scale;
       }
       if (player.transform.position.x > enemyPlant[2].transform.position.x)
       {
           Vector3 scale = enemyPlant[2].transform.localScale;
           scale.x = scale.x * -1;
           enemyPlant[2].transform.localScale = scale;
       }
       if (player.transform.position.x > enemyPlant[3].transform.position.x)
       {
           Vector3 scale = enemyPlant[3].transform.localScale;
           scale.x = scale.x * -1;
           enemyPlant[3].transform.localScale = scale;
       }
       if (player.transform.position.x > enemyPlant[4].transform.position.x)
       {
           Vector3 scale = enemyPlant[4].transform.localScale;
           scale.x = scale.x * -1;
           enemyPlant[4].transform.localScale = scale;
       }
       if (player.transform.position.x > enemyPlant[5].transform.position.x)
       {
           Vector3 scale = enemyPlant[5].transform.localScale;
           scale.x = scale.x * -1;
           enemyPlant[5].transform.localScale = scale;
       }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="Player")
        {
            Vector3 scale = enemyPlant.transform.localScale;
            scale.x = scale.x * -1;
            enemyPlant.transform.localScale = scale;
        }*/

    }
}
