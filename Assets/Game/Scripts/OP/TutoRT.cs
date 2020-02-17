using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutoRT : MonoBehaviour
{
    [SerializeField] GameObject MainPanel;
    [SerializeField] GameObject TutoPanel1;
    [SerializeField] GameObject TutoPanel2;
    [SerializeField] GameObject TutoPanel3;
    [SerializeField] GameObject TutoPanel4;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("00");
            MainPanel.SetActive(true);
            TutoPanel1.SetActive(false);
            TutoPanel2.SetActive(false);
            TutoPanel3.SetActive(false);
            TutoPanel4.SetActive(false);
        }
    }
}
