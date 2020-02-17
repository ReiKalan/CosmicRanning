using UnityEngine;
//①.Unityシステムを利用する際に使用（今回はpointText）
using UnityEngine.UI;

public class Point2 : MonoBehaviour
{
    //②比較の為の変数getpointの導入
    public static float  getPoint;
    public void Update()
    {

        //Debug.Log(Out.point);
        //③もし、現時点のgetpointがOut.csのpoint変数に数値を越された場合
        if (getPoint< Out2.pointtwo)
        {
            //④お互いの変数の値は等しくなり、テキストコンポーネントを再取得しテキストボックス内の数値を逐一更新する 
            Text PointText = GetComponent<Text>();
            getPoint = Out2.pointtwo;
            PointText.text = "得点" + getPoint;
        }

    }
}