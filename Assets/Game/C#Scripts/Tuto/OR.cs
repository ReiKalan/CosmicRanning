using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OR : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T) && Input.GetKeyDown(KeyCode.B))
        {
            Debug.Log("XX");
            SceneManager.LoadScene("OP");
        }
    }
}
