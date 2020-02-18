using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Save : MonoBehaviour
{
    public  Vector3 _hit_position;
    // Update is called once per frame
    //何らかのオブジェクトがSavePointにぶつかって
    void OnTriggerEnter(Collider collision)
    {
        //そのオブジェクトの名称がプレイヤーの場合に
        if (collision.gameObject.tag == "Player")
        {
            //Debug.Log(collision.gameObject.name);
             Vector3 _hit_position = collision.ClosestPointOnBounds(this.transform.position);
        }
    }
}
