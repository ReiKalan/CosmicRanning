using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        //4.そのオブジェクトの名称がプレイヤーの場合に
        if (collision.gameObject.name == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Tutorial")
            {
                SceneManager.LoadScene("Tutorial");
                
            }
            else
            {
                SceneManager.LoadScene("GameCrear");
            }
        }

        
    }
}
