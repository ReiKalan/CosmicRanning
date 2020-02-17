//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//①.Unityシステムを利用する際に使用（今回はTimerText）
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //②.時間経過に使う変数timeの宣言
    public static float time;

    void Start()
    {
        //③.ゲーム開始時には45秒(ほんへは100秒)
        time = 45;
    }


    void Update()
    {
        //④.ゴールしていない（false）ならば
        if (Goal.is_goal == false)
        {
            //⑤.経過時間を減少させ
            time = time - Time.deltaTime;
        }
         if (Goal.is_goal == true)
        {
            //mainを取得する
            SceneManager.LoadScene("Main");
        }
        if (time <= 1)
        {
            //Mainを取得する
            SceneManager.LoadScene("Main");
        }
        //⑥.小数点以下は切り捨て
        int t = Mathf.FloorToInt(time);
        //⑦.テキストのコンポーネントを取得し
        Text TimerText = GetComponent<Text>();
        //⑧.テキストを書き換える
        TimerText.text = "残り時間" + t;

        PositionInitialize.is_player_contact = false;
    }
}
