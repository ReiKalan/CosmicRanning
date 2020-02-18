using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//Unityシステム
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;


public class ReturnTimer : MonoBehaviour
{
    //テキストのコンポーネントを取得し
    Text _aleltimer = null;
    public float _return_tiem = 10;


    // Start is called before the first frame update
    void Start()
    {
        // 0以下の場合初期化
        if (_return_tiem < 0)
        {
            _return_tiem = 10;
        }

        // _aleltimerに何も設定されてない場合取得
        if (_aleltimer == null)
        {
            _aleltimer = GameObject.FindGameObjectWithTag("CountDown").GetComponent<Text>();
        }
    }

    // Update is called once per frame
    void Update()
    {
        // カウントダウンが０以下の場合、またはT&Kを同時押ししたときにタイトルに戻る
        if (_return_tiem <= 1 || ( Input.GetKeyDown(KeyCode.T) && Input.GetKeyDown(KeyCode.B) ) )
        {
            SceneManager.LoadScene("Title");
        }
        else
        {
            _return_tiem = _return_tiem - Time.deltaTime;
        }
        
        //小数点以下は切り捨て
        //テキストを書き換える
        _aleltimer.text = "後"+ Mathf.FloorToInt(_return_tiem) +"秒でOPにもどります";
    }
}
