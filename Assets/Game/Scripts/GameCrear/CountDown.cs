using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Unityシステム
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public static float _count;
    // Start is called before the first frame update
    void Start()
    {
        _count = 11;
    }

    // Update is called once per frame
    void Update()
    {
        
        if (FinishDirector._activate == true)
        {
            _count = _count - Time.deltaTime;
        }
        if (_count <= 1)
        {
            //OPを取得する
            SceneManager.LoadScene("Title");
        }
        //小数点以下は切り捨て
        int CLRt = Mathf.FloorToInt(_count);
        //テキストのコンポーネントを取得し
        Text COUNT = GetComponent<Text>();
        //テキストを書き換える
        COUNT.text = "OPまで" + CLRt +"秒";
        if ((Input.GetKeyDown(KeyCode.T)) && (Input.GetKeyDown(KeyCode.B)))
        {
            SceneManager.LoadScene("Title");

        }
    }
    
}