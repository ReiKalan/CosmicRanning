using UnityEngine;
using UnityEngine.UI;
//ユニティでシーン関係の操作を行う時のスクリプト
using UnityEngine.SceneManagement;


public class Out : MonoBehaviour
{
    //②.ポイント加算に使う変数の宣言
    public static float _point = 0;
    public static float _small_point = 200;
    public static float _large_point = 500;
    //SE再生に使う変数　_small_sound、_large_soundの準備
    public AudioClip _small_sound;
    public AudioClip _large_sound;
    AudioSource _audio;

    void Start()
    {
        _audio = GetComponent<AudioSource>();
        
        //③.ゲーム開始時には0
        if(_point != 0)
        {
            _point = 0;
        }

    }

    //④これからCollision（衝突）するよ「3パターン分岐」
    void OnCollisionEnter(Collision col)
    {
        // Tag取得ログ
        Debug.Log(col.gameObject.tag);
        // 小さい箱が当たったら
        if (col.gameObject.tag == "SmallBox")
        {
            AddPoint(_small_point, _small_sound, col.gameObject);
        }
        // 大きい箱が当たったら
        else
        {
            AddPoint(_large_point, _large_sound, col.gameObject);
        }
        
        if (col.gameObject.name == "Player")
        {
            if (SceneManager.GetActiveScene().name == "Tutorial")
            {
                SceneManager.LoadScene("Tutorial");
                
            }
            else
            {
                SceneManager.LoadScene("GameOver");
            }
        }
    }

    void AddPoint(float point, AudioClip _sound,　GameObject obj)
    {
        // 加点
        _point = _point + point;
        // 音声を鳴らす
        _audio.PlayOneShot(_sound);
        // オブジェクトを削除
        Destroy(obj);
    }
}



