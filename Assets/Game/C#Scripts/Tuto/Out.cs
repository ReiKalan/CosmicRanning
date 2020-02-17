using UnityEngine;
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;


public class Out : MonoBehaviour
{
    //②.ポイント加算に使う変数の宣言
    public static float point;
    public static float Lpoint;
    public static float Bpoint;
    //SE再生に使う変数　LSE、BSEの準備
    public AudioClip LSE;
    public AudioClip BSE;
    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
        //③.ゲーム開始時には0
        point = 0;
        Lpoint = 200;
        Bpoint = 500;
       
    }
    //④これからCollision（衝突）するよ「3パターン分岐」
    void OnCollisionEnter(Collision col)
    {
        //⑤-②-①もし小さい箱が当たったら
        if (col.gameObject.tag == "L-Box")
        {
            //⑤-②-②point変数に200加点し
            point = point + Lpoint;
            //tag取得出来ているかのテスト用
            Debug.Log(col.gameObject.tag);
            //音声を鳴らす
            audioSource.PlayOneShot(LSE);
            //⑤-②-③そのオブジェクトを削除
            Destroy(col.gameObject);



        }
        //⑤-③-①もし大きい箱が当たったら
        else if (col.gameObject.tag == "B-Box")
        {
            //⑤-③-②point変数に500加点し
            point = point + Bpoint;
            //tag取得出来ているかのテスト用
            Debug.Log(col.gameObject.tag);
            //音声を鳴らす
            audioSource.PlayOneShot(BSE);
            //⑤-③-③そのオブジェクトを削除
            Destroy(col.gameObject);

        }
    }
}



