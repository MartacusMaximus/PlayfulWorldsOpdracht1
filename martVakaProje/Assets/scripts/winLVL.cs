using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class winLVL : MonoBehaviour {

    public GameObject menu;
    private bool won;
    private CursorLockMode savedCursorLockMode;
    private float StartTime;
    private float TimeTaken;

    private void Start()
    {
        StartTime = Time.time;   
    }

    private void LateUpdate()
    {
        if(GameObject.FindWithTag("target") == null && !won)
        {
            savedCursorLockMode = Cursor.lockState;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            this.GetComponent<FirstPersonController>().enabled = false;
            won = true;
            TimeTaken = Time.time - StartTime;
        }
    }

    private void OnGUI()
    {
        if (won)
        {
            menu.gameObject.SetActive(true);
        }
    }

    private void setBackUp()
    {
        Cursor.lockState = savedCursorLockMode;
        Cursor.visible = false;
        this.GetComponent<FirstPersonController>().enabled = true;
    }

    public void tryAgain()
    {
        setBackUp();
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void nextLevel()
    {
        if (SceneManager.GetActiveScene().name != "lvl5")
        {
            setBackUp();
            switch (SceneManager.GetActiveScene().name)
            {
                case "PlayGround":
                    SceneManager.LoadScene("lvl1");
                    break;
                case "lvl1":
                    SceneManager.LoadScene("lvl2");
                    break;
                case "lvl2":
                    SceneManager.LoadScene("lvl3");
                    break;
                case "lvl3":
                    SceneManager.LoadScene("lvl4");
                    break;
                case "lvl4":
                    SceneManager.LoadScene("lvl5");
                    break;

            }
        }
    }

    public void lvlSelect()
    {
            SceneManager.LoadScene("LVLSelect");
    }
}
