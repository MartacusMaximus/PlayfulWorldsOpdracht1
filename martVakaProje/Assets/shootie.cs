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
        if (GameObject.FindWithTag("projectile") == null)
        {
            if (Input.GetButtonDown("Fire1")) //LMB
            {
                Instantiate(projectile);
            }
        }
	}
}
