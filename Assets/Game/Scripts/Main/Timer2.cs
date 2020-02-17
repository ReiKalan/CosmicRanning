//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//①.Unityシステムを利用する際に使用（今回はTimerText）
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer2 : MonoBehaviour
{
    //②.時間経過に使う変数timetwoの宣言
    public static float timetwo;
    public static float Penalty;

    void Start()
    {
        //③.ゲーム開始時には100秒
        timetwo = 100;
        Penalty = -10;
    }
    public void LateUpdate()
    {
        if (PositionInitialize.is_player_contact == true)
        {
           timetwo = timetwo + Penalty;
            //Debug.Log(timetwo);
        }
    }
    void Update()
    {
        //④.ゴールしていない（false）ならば
        if (Goal.is_goal == false)
        {
            //⑤.経過時間を減少させ
            timetwo = timetwo - Time.deltaTime;
        }

        if (Goal.is_goal == true)
        {

            SceneManager.LoadScene("GameCrear");
        }
        
        if (timetwo <= 1)
        {
            //GAMEOVERを取得する
            SceneManager.LoadScene("GameOver");
        }

        //⑥.小数点以下は切り捨て
        int t = Mathf.FloorToInt(timetwo);
        //⑦.テキストのコンポーネントを取得し
        Text TimerText = GetComponent<Text>();
        //⑧.テキストを書き換える
        TimerText.text = "残り時間" + t;

        PositionInitialize.is_player_contact = false;
    }
    
}
