using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winLVL : MonoBehaviour {

    private bool won;
    private void LateUpdate()
    {
        if(GameObject.FindWithTag("target") == null && !won)
        {
            Debug.Log("YOU WIN");
            won = true;
        }
    }
}
