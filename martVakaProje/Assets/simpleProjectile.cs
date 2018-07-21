using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleProjectile : MonoBehaviour {

    private GameObject player;
    private Rigidbody ribBod;
    

    public float speed;
	// Use this for initialization
	void Start () {
        player = GameObject.Find("FPSController");
        this.ribBod = GetComponent<Rigidbody>();
        this.GetComponent<Transform>().rotation = player.GetComponent<Transform>().GetChild(0).GetComponent<Transform>().rotation;
        this.GetComponent<Transform>().position = player.GetComponent<Transform>().GetChild(0).GetComponent<Transform>().position
                                                - (Vector3.up * (float)0.3); // projectile height
        this.GetComponent<Transform>().position += (this.GetComponent<Transform>().forward * (float) 2); // projectile forward

        Physics.IgnoreLayerCollision(8, 9); //8:player 9:projectile
        Physics.IgnoreLayerCollision(9, 9);
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        ribBod.velocity = this.GetComponent<Transform>().forward * speed;
	}

    private void OnCollisionEnter(Collision collision)
    {
        Destroy(transform.gameObject);
    }
}
