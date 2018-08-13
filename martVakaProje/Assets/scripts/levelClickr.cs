using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class levelClickr : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0))
        { // if left button pressed...
            Ray ray = GameObject.FindObjectOfType<Camera>().ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                string name = hit.transform.gameObject.name;
                
                switch (name)
                {
                    case "PlayGround":
                        SceneManager.LoadScene("PlayGround");
                        break;
                    case "lvl1":
                        SceneManager.LoadScene("lvl1");
                        break;
                    case "lvl2":
                        SceneManager.LoadScene("lvl2");
                        break;
                    case "lvl3":
                        SceneManager.LoadScene("lvl3");
                        break;
                    case "lvl4":
                        SceneManager.LoadScene("lvl4");
                        break;
                    case "lvl5":
                        SceneManager.LoadScene("lvl5");
                        break;
                }
            }
        }
    }
}
