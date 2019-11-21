using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class targetGetHit : MonoBehaviour {

    [Range(0,4)]
    public int numberOfChildren;

    public GameObject childTarget;

    private float spread;
    // Use this for initialization
	void Start () {
        spread = this.GetComponent<SphereCollider>().radius * this.GetComponent<Transform>().localScale.x; //for spheres scale.x .y and .z are the same         
	}

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "projectile")
        {
            Explode();

            Destroy(transform.gameObject);
        }
    }

    public void Explode()
    {
        Vector3 pos = this.GetComponent<Transform>().position;
        Quaternion rot = this.GetComponent<Transform>().rotation;
        List<GameObject> goList = new List<GameObject>();
        switch (numberOfChildren)
        {
            case 0:
                break;
            case 1:
                GameObject go01 = Instantiate(childTarget, pos, rot);
                goList.Add(go01);
                break;
            case 2:
                GameObject go10 = Instantiate(childTarget, pos + new Vector3(-spread, 0, 0), Quaternion.Euler(0, -90, 0));
                GameObject go11 = Instantiate(childTarget, pos + new Vector3(spread, 0, 0), Quaternion.Euler(0, 90, 0));
                goList.Add(go10);
                goList.Add(go11);
                break;
            case 3: //make the new objects spawn in a triangle pattern
                float fac1 = 0.866f; //~root(3)/2 (unity-circle)
                float fac0 = 0.5f; //1/2
                GameObject go20 = Instantiate(childTarget, pos + new Vector3(-spread, 0, 0), Quaternion.Euler(0, 0, 0));
                GameObject go21 = Instantiate(childTarget, pos + new Vector3(spread * fac0, 0, spread * fac1), Quaternion.Euler(0, 120, 0));
                GameObject go22 = Instantiate(childTarget, pos + new Vector3(spread * fac0, 0, -spread * fac1), Quaternion.Euler(0, 240, 0));
                goList.Add(go20);
                goList.Add(go21);
                goList.Add(go22);
                break;
            case 4:
                GameObject go30 = Instantiate(childTarget, pos + new Vector3(spread, 0, 0), Quaternion.Euler(0, 90, 0));
                GameObject go31 = Instantiate(childTarget, pos + new Vector3(-spread, 0, 0), Quaternion.Euler(0, 270, 0));
                GameObject go32 = Instantiate(childTarget, pos + new Vector3(0, 0, spread), Quaternion.Euler(0, 0, 0));
                GameObject go33 = Instantiate(childTarget, pos + new Vector3(0, 0, -spread), Quaternion.Euler(0, 180, 0));
                goList.Add(go30);
                goList.Add(go31);
                goList.Add(go32);
                goList.Add(go33);
                break;
        }
        foreach(GameObject go in goList) //push newly spawned targets up
        {
            go.GetComponent<Rigidbody>().AddForce(new Vector3(0, 16, 0), ForceMode.VelocityChange);
        }
    }
}
