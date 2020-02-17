using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //変数の宣言
    public static bool goal; //1.goal変数がtrueの時にゴールになる

    void Start()
    {
        goal = false; //2.最初にgoal変数はfalseと定義する
    }

    //3.その状態で何らかのオブジェクトが（Goal)にぶつかって
    void OnTriggerEnter(Collider collision)
    {
        //4.そのオブジェクトの名称がプレイヤーの場合に
        if (collision.gameObject.name == "Player")
        {
            //EX.name取得出来ているかのテスト用
            //Debug.Log(collision.gameObject.name);
            //5.goal変数はtrueになる
            goal = true;
        }
    }
}
