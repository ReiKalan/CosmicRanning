using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;

public class G_O : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if ((Input.GetKeyDown(KeyCode.T)) && (Input.GetKeyDown(KeyCode.B)))
        {
            SceneManager.LoadScene("OP");

        }
    }
}
