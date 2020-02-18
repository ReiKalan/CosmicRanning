//using System.Collections;
//using System.Collections.Generic;
using UnityEngine;
//①.Unityシステムを利用する際に使用（今回は_timer_text）
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    //②.時間経過に使う変数timeの宣言
    [SerializeField] public float _time = 45;
    public float _penalty = -10;
    Text _timer_text = null;
    void Start()
    {
        if(_timer_text == null)
        {
            _timer_text = GetComponent<Text>();
        }
    }

    public void LateUpdate()
    {
        if (PositionInitialize.is_player_contact == true)
        {
           _time = _time + _penalty;
        }
    }

    void Update()
    {
        if (_time <= 1)
        {
            if (SceneManager.GetActiveScene().name == "Tutorial")
            {
                SceneManager.LoadScene("Tutorial");
                
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }

        // 時間を更新
        _time = _time - Time.deltaTime;
        PlayerPrefs.SetInt("Time", Mathf.FloorToInt(_time));

        // 小数点以下は切り捨て、テキストを書き換える
        _timer_text.text = "残り時間" + Mathf.FloorToInt(_time);

        PositionInitialize.is_player_contact = false;
    }
}
