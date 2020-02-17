using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTtriger : MonoBehaviour
{
    public static bool RTTRIGER;
    // Start is called before the first frame update
    void Start()
    {
        RTTRIGER = false;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            RTTRIGER = true;
            //Debug.Log(RTTRIGER);
           

        }

    }
}
