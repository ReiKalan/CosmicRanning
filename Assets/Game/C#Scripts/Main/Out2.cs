using UnityEngine;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;


public class Out2 : MonoBehaviour
{
    //②.ポイント加算に使う変数の宣言
    public static float pointtwo;
    public static float Lpointtwo;
    public static float Bpointtwo;
    //SE再生に使う変数　LSE、BSEの準備
    public AudioClip LSE;
    public AudioClip BSE;

    AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        //③.ゲーム開始時には0
        pointtwo = 0;
        Lpointtwo = 200;
        Bpointtwo = 500;

    }
    //④これからCollision（衝突）するよ「3パターン分岐」
    void OnCollisionEnter(Collision col)
    { 
   
        //⑤-②-①もし小さい箱が当たったら
        if (col.gameObject.tag == "L-Box")
        {
            //⑤-②-②point変数に200加点し
            pointtwo = pointtwo + Lpointtwo;
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
            pointtwo = pointtwo + Bpointtwo;
            //tag取得出来ているかのテスト用
            Debug.Log(col.gameObject.tag);
            //音声を鳴らす
            audioSource.PlayOneShot(BSE);
            //⑤-③-③そのオブジェクトを削除
            Destroy(col.gameObject);

        }
}   }





