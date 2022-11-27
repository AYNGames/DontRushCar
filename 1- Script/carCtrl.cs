using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carCtrl : MonoBehaviour
{

    public GameObject[] frontWhell;
    public GameObject[] frontWhellRoot;
    public GameObject[] backWhell;
    //BallController BallController;


    Animator animCtrl;
    // Start is called before the first frame update
    void Start()
    {
        animCtrl = GetComponent<Animator>();
        //BallController = GetComponentInParent<BallController>();
    }

    int trickIndex = 1;
    int lastTrickIndex = 1;
    public void idleAnim()
    {
        animCtrl.SetInteger("trickIndex", 0);
    }
    public void trickAnim()
    {
        animCtrl.SetInteger("trickIndex", lastTrickIndex);

        trickIndex++;
        if (trickIndex > 9)
            trickIndex = 1;
        lastTrickIndex = trickIndex;

    }
    private void Update()
    {


        float horizontalInput = Input.GetAxis("Horizontal");

        for (int i = 0; i < frontWhellRoot.Length; i++)
        {
            frontWhellRoot[i].transform.transform.localEulerAngles = new Vector3(0, horizontalInput*35, 0);
        }


        for (int i = 0; i < frontWhell.Length; i++)
        {
            frontWhell[i].transform.Rotate(20, 0,0 );
        }
        for (int i = 0; i < backWhell.Length; i++)
        {
            backWhell[i].transform.Rotate(20, 0, 0);
        }
    }
}
