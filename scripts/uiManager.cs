using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class uiManager : MonoBehaviour
{
    public float coins = 0f;
    public Text cointext;
    public GameObject panel;
    public static bool GameIsPaused = false;
    // Start is called before the first frame update
    void Start()
    {
          
    }
    // Update is called once per frame
    void Update()
    {
        cointext.text = "X" + coins;
    }
    public void replay()
    {
        SceneManager.LoadScene("level1");
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void coinIncrease()
    {
        coins = coins+1f ;
    }
    public void Mainmenu()
    {
        SceneManager.LoadScene("mainmenu");
        Time.timeScale = 1f;
        GameIsPaused = false;
    }
    public void menupanel()
    {
        if (panel != null)
        {
            bool isActive = panel.activeSelf;
           
            if(isActive==true)
            {
                Time.timeScale = 1f;
                GameIsPaused = false;
            }
            else
            {
                Time.timeScale = 0f;
                GameIsPaused = true;
            }
            panel.SetActive(!isActive);


        }
    }
    public void Quitgame()
    {
        Application.Quit();
    }
 

}
