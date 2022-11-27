using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class environmentCtrl : MonoBehaviour
{


    public GameObject[] environments;
    // Start is called before the first frame update
    void Start()
    {
        chanceEnvironment(PlayerPrefs.GetInt("debugEnviIndex", 1));
    }

 

    public void chanceEnvironment(int index)
    {

        for (int i = 0; i < environments.Length; i++)
        {
            if(i == index)
            {
                environments[i].SetActive(true);
            }
            else
            {
                environments[i].SetActive(false);
            }
        }
    }
}
