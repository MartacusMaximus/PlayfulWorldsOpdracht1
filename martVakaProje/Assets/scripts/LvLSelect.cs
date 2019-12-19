using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LvLSelect : MonoBehaviour
{
    public string levelName;


    public void LvlSelect(string levelName)
    {
        SceneManager.LoadScene(levelName);
    }

}
