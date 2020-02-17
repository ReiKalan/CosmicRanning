using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour
{
    //変数の宣言
    public static bool _is_goal; //1.is_goal変数がtrueの時にゴールになる
    
    public static bool is_goal
    {
        get { return _is_goal; }
    }

    void Start()
    {
        _is_goal = false; //2.最初にis_goal変数はfalseと定義する
    }

    //3.その状態で何らかのオブジェクトが（Goal)にぶつかって
    void OnTriggerEnter(Collider collision)
    {
        //4.そのオブジェクトの名称がプレイヤーの場合に
        if (collision.gameObject.name == "Player")
        {
            //EX.name取得出来ているかのテスト用
            //Debug.Log(collision.gameObject.name);
            //5.is_goal変数はtrueになる
            _is_goal = true;
        }
    }
}
