using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DescriptionController : MonoBehaviour
{
    public int _page = 0;
    public List<GameObject> _panels = new List<GameObject>();

    void OnEnable()
    {
        // 初期化
        _page = 0;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PanelReset();

        foreach (var (panel, index) in _panels.Select((item, index) => (item, index)))
        {
            // パネルのページ数に応じたオブジェクトを状態を変更
            bool is_active = (index == _page);
            panel.SetActive(is_active);
        }
    }

    /// <summary>
    /// ページリセットコマンド
    /// </summary>
    private void PanelReset()
    {
        if (Input.GetKeyDown(KeyCode.T) && Input.GetKeyDown(KeyCode.B))
        {
            _page = 0;
        }
    }

    /// <summary>
    /// ページ送り
    /// </summary>
    public void Next()
    {
        if(_page < _panels.Count)
        {
            _page++;
        }
    }

    /// <summary>
    /// ページ戻し
    /// </summary>
    public void Back()
    {
        if(_page > 0)
        {
            _page--;
        }
    }


}
