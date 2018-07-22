using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simpleProjectile : MonoBehaviour {

    private Vector3 startPoint;

    public float speed;

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody>().velocity = this.GetComponent<Transform>().forward * speed;
        
        startPoint = this.GetComponent<Transform>().position;

        Physics.IgnoreLayerCollision(8, 9); //8:player 9:projectile
        Physics.IgnoreLayerCollision(9, 9);
    }

    private void Update()
    {        
        float dist = Vector3.Distance(startPoint, this.GetComponent<Transform>().position);
        GetComponent<CapsuleCollider>().center =  new Vector3(0,0,-dist/2f);
        GetComponent<CapsuleCollider>().height = dist;
    }



    private void OnCollisionEnter(Collision collision)
    {
        Destroy(transform.gameObject);
    }
}
