using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerGetHit : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "target")
        {
            Debug.Log("Get hit newb");
        }
    }
}
