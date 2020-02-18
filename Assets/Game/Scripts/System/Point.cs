using UnityEngine;
//①.Unityシステムを利用する際に使用（今回はpointText）
using UnityEngine.UI;


public class Point : MonoBehaviour
{
    //②比較の為の変数getpointの導入
    public float _point;
    Text _point_text = null;
    
    public void Start()
    {
        if(_point_text == null)
        {
            _point_text = GetComponent<Text>();
        }
    }

    public void Update()
    {
        // 得点が変更されたときにテキストを更新
        if (_point != Out._point)
        {
            PlayerPrefs.SetInt("Point", Mathf.FloorToInt(_point));
            _point = Out._point;
            _point_text.text = "得点" + _point;
        }

    }
}
