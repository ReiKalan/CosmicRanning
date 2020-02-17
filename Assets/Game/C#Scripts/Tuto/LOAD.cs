using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOAD : MonoBehaviour
{
    public GameObject GameObject;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 num = GameObject.GetComponent<SAVE>().hitPos;
            this.transform.position = num;
        }
        if (RTtriger.RTTRIGER ==true)
        {
            Vector3 num = GameObject.GetComponent<SAVE>().hitPos;
            this.transform.position = num;
            //Debug.Log(num);
        }

    }


}
