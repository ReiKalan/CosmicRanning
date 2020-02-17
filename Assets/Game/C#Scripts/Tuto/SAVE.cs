using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SAVE : MonoBehaviour
{
    public  Vector3 hitPos;
    // Update is called once per frame
    //何らかのオブジェクトがSavePointにぶつかって
    void OnTriggerEnter(Collider collision)
    {
       
        //そのオブジェクトの名称がプレイヤーの場合に
        if (collision.gameObject.tag == "Player")
        {
            //EX.name取得出来ているかのテスト用
            //Debug.Log(collision.gameObject.name);
             Vector3 hitPos = collision.
               ClosestPointOnBounds(this.transform.position);
        }
    }
}
