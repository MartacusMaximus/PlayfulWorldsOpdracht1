using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shootie : MonoBehaviour {

    public GameObject projectile;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GameObject.FindWithTag("projectile") == null && Time.timeScale != 0) //only one projectile in the world at any one time
        {
            if (Input.GetButtonDown("Fire1")) //LMB
            {
                Transform gunner = GetComponent<Transform>().GetChild(0).GetComponent<Transform>();
                Instantiate(projectile, gunner.position
                                         + (gunner.up * -0.33f) //height offset
                                         + (gunner.forward * 1.53f) //forwards offset
                                         + (gunner.right * 0.71f), //right offset
                                         GetComponent<Transform>().GetChild(0).GetComponent<Transform>().rotation);
            }
        }
	}
}
