using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;

public class FinishDirector : MonoBehaviour
{
    public static bool _activate;
    public int _best_time = 0;
    public int _best_point = 0;

    // プレイリザルト
    public Text _time_text;
    public Text _point_text;
    
    // ベストリザルト
    public Text _best_time_text;
    public Text _best_point_text;

    [SerializeField] public GameObject _result_obj;
    [SerializeField] public GameObject _thanks_obj;

    [SerializeField] public GameObject _best_time_obj;
    [SerializeField] public GameObject _best_point_obj;

    void OnEnable()
    {    
        _activate = false;
        _result_obj.SetActive(true);
        _thanks_obj.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.HasKey("BestTime"))
        {
            _best_time = PlayerPrefs.GetInt("BestTime");
        }

        if (PlayerPrefs.HasKey("BestPoint"))
        {
            _best_point = PlayerPrefs.GetInt("BestPoint");
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal.is_goal == true)
        {
            int time = Mathf.FloorToInt(Timer2.timetwo);
            int point = time * 100 + Mathf.FloorToInt(Point2.getPoint);

            UpadteResult(time, point);
        }
    }

    /// <summary>
    /// Thenksパネル表示
    /// </summary>    
    public void ViewThanks()
    {
        _activate = true;
        _result_obj.SetActive(false);
        _thanks_obj.SetActive(true);
    }

    /// <summary>
    //// リザルトメッセージ更新処理
    /// </summary>
    /// <param name="time">時間</param>
    /// <param name="point">ポイント</param>
    private void UpadteResult(int time, int point)
    {
        _time_text.text = "残り時間" + time + "秒";
        _point_text.text = "獲得点数" + point + "ポイント";

        // ベストタイム更新
        if (_best_time < time)
        {
            _best_time_obj.SetActive(true);
            _best_time_text.text = "NICE!! ベストタイム" + point + "秒";
            PlayerPrefs.SetInt("FinishBestPoint", point);
        }
            
        // ベストスコア更新
        if (_best_point < point)
        {
            _best_point_obj.SetActive(true);
            _best_point_text.text = "NICE!! 最高点数" + point + "ポイント";
            PlayerPrefs.SetInt("FinishBestPoint", point);
        }
    }

}
