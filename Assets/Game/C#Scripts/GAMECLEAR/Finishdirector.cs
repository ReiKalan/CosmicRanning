using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;

public class Finishdirector : MonoBehaviour
{
    public static bool ACTYVETE;
    private int BestTIME;
    //ベストタイム格納用変数
    public Text FinishTIME;
    public Text BESTTIME;
    private int BestPOINT;
    public Text FinishPOINT;
    public Text BESTPOINT;

    [SerializeField] public GameObject RESULTPanel;
    [SerializeField] public GameObject FinishBestTimetext;
    [SerializeField] public GameObject FinishBestPointtext;
    [SerializeField] public GameObject SUNKSPANEL;
    // Start is called before the first frame update
    void Start()
    {
        ACTYVETE = false;
        GOSUNKS();

        RESULTPanel.SetActive(true);
        FinishBestPointtext.SetActive(false);
        SUNKSPANEL.SetActive(false);

        if (PlayerPrefs.HasKey("FinishBestTimetext"))
        {
            BestTIME = PlayerPrefs.GetInt("FinishBestTimetext");
            //Debug.Log(BestTIME);
        }
        else
        {
            BestTIME = 0;
            //Debug.Log(BestTIME);
        }

        if (PlayerPrefs.HasKey("FinishBestPointtext"))
        {
            BestPOINT = PlayerPrefs.GetInt("FinishBestPointtext");
            //Debug.Log(BestPOINT);
        }
        else
        {
            BestPOINT = 0;
            // Debug.Log(BestPOINT);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Goal.goal == true)
        {
            int Tscore = Mathf.FloorToInt(Timer2.timetwo);
            //Debug.Log(Tscore);
            int Pscore = Mathf.FloorToInt(Point2.getPoint);

            int TIMEPOINTSCORE = Tscore * 100 + Pscore;

            //Debug.Log(Pscore);

            FinishTIME.text = "残り時間" + Tscore + "秒";

            FinishPOINT.text = "獲得点数" + TIMEPOINTSCORE + "ポイント";

            

            if (BestPOINT < TIMEPOINTSCORE)
            {
                FinishBestPointtext.SetActive(true);
                PlayerPrefs.SetInt("FinishBestPoint", TIMEPOINTSCORE);
                BESTPOINT.text = "NICE!! 最高点数" + TIMEPOINTSCORE + "ポイント";
                //Debug.Log("FinishBesTPoint");
            }

        }


    }
    public void GOSUNKS()
    {
        ACTYVETE = true;
        RESULTPanel.SetActive(false);
        SUNKSPANEL.SetActive(true);

    }

}
