using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Unityシステム
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;


public class ReturnTiemr : MonoBehaviour
{
    public static float Rttime;
    // Start is called before the first frame update
    void Start()
    {
        Rttime = 10;
    }

    // Update is called once per frame
    void Update()
    {
     
        if(Rttime > 1)
        {
            Rttime = Rttime - Time.deltaTime;
        }
        if (Rttime <= 1)
        {
            //OPを取得する
            SceneManager.LoadScene("OP");
        }
        //小数点以下は切り捨て
        int Rt = Mathf.FloorToInt(Rttime);
        //テキストのコンポーネントを取得し
        Text aleltTimer = GetComponent<Text>();
        //テキストを書き換える
        aleltTimer.text = "後"+ Rt+"秒でOPにもどります";
    }
}
