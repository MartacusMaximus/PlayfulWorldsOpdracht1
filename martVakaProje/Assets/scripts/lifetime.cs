using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lifetime : MonoBehaviour
{
    private float life = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, life);

    }

}
