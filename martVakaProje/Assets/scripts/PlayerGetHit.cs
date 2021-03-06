﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerGetHit : MonoBehaviour {

    public GameObject menu;
    private bool lost;
    private float savedTimeScale;
    private CursorLockMode savedCursorLockMode;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void Update()
    {
        if (lost)
        {
            Debug.Log("LOSE");

            menu.gameObject.SetActive(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target" && !lost)
        {
            lost = true;
            savedTimeScale = Time.timeScale;
            savedCursorLockMode = Cursor.lockState;

            Cursor.lockState = CursorLockMode.None;
            Cursor.visible = true;
            Time.timeScale = 0;
            this.GetComponent<FirstPersonController>().enabled = false;

        }
    }


    
    private void setBackUp()
    {
        Time.timeScale = savedTimeScale;
        Cursor.lockState = savedCursorLockMode;
        Cursor.visible = false;
        this.GetComponent<FirstPersonController>().enabled = true;
    }
}
