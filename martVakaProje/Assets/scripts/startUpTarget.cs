using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startUpTarget : MonoBehaviour {

    public float speed;
    public bool spawned;  

	// Use this for initialization
	void Start () {
        GameObject player = GameObject.Find("FPSController");
        this.GetComponent<Rigidbody>().velocity = this.GetComponent<Transform>().forward * speed;        
        Physics.IgnoreLayerCollision(10, 10); //ignore collision with other targets
        Physics.IgnoreCollision(GetComponent<SphereCollider>(), player.GetComponent<CharacterController>()); //use seperate capsule collider on player for hit detection

    }
    private void Update()
    {
        transform.Rotate(speed, speed, speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "floor")
        {
            var x = this.GetComponent<Rigidbody>().velocity.x;
            var z = this.GetComponent<Rigidbody>().velocity.z;
            this.GetComponent<Rigidbody>().velocity = new Vector3(x, speed, z);

        }
    }
}
