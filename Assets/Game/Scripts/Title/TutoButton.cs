using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class TutoButton : MonoBehaviour
{
    Button button;
    Button Two;
    Button Three;
    Button four;
    Button five;

    //5つのパネルを格納
    //インスペクターウィンドウからゲームオブジェクトを設定
    [SerializeField] GameObject MainPanel;
    [SerializeField] GameObject TutoPanel1;
    [SerializeField] GameObject TutoPanel2;
    [SerializeField] GameObject TutoPanel3;
    [SerializeField] GameObject TutoPanel4;
    
    void Start()
    {
        //BacktoMain();
        BackToTu1();
        BackToTu2();
        BackToTuRt();
        MainPanel.SetActive(true);
        TutoPanel1.SetActive(false);
        TutoPanel2.SetActive(false);
        TutoPanel3.SetActive(false);
        TutoPanel4.SetActive(false);
        button = GameObject.Find("TitleWindow/MainPanel/MainButton").GetComponent<Button>();
        button.Select();

    }
    public void Movegame()
    {
        SceneManager.LoadScene("Main");
    }
    public void SelectTuto1Description()
    {
        MainPanel.SetActive(false);
        TutoPanel1.SetActive(true);
        Two = GameObject.Find("TitleWindow/TutoPanel 1/MoveButtontu2").GetComponent<Button>();
        Two.Select();
    }

    public void SelectTuto2Description()
    {
        TutoPanel2.SetActive(true);
        TutoPanel1.SetActive(false);
        Three = GameObject.Find("TitleWindow/TutoPanel2/MoveButtontu３").GetComponent<Button>();
        Three.Select();
    }
    public void BacktoMain()
    {
        TutoPanel1.SetActive(false);
        MainPanel.SetActive(true);
    }
    public void BackToTu1()
    {
        TutoPanel2.SetActive(false);
        TutoPanel1.SetActive(true);
        Two = GameObject.Find("TitleWindow/TutoPanel 1/MoveButtontu2").GetComponent<Button>();
        Two.Select();
    }
    public void SelectTuto3Description()
    {
        TutoPanel3.SetActive(true);
        TutoPanel2.SetActive(false);
        four = GameObject.Find("TitleWindow/TutoPanel3/MoveButtonlas").GetComponent<Button>();
        four.Select();
    }
    public void BackToTu2()
    {
        TutoPanel3.SetActive(false);
        TutoPanel2.SetActive(true);
        Three = GameObject.Find("TitleWindow/TutoPanel2/MoveButtontu３").GetComponent<Button>();
        Three.Select();
    }
    public void SelectTuto4Description()
    {
        TutoPanel4.SetActive(true);
        TutoPanel3.SetActive(false);
        five = GameObject.Find("TitleWindow/TutoPanel4/MoveButtontuSt").GetComponent<Button>();
        five.Select();
    }
    public void BackToTuRt()
    {
        TutoPanel4.SetActive(false);
        TutoPanel1.SetActive(true);
        Two = GameObject.Find("TitleWindow/TutoPanel 1/MoveButtontu2").GetComponent<Button>();
        Two.Select();
    }
    public void MoveToTuSt()
    {
        SceneManager.LoadScene("Tutorial");
    }
    

}
