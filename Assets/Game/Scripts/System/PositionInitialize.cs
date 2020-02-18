using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionInitialize : MonoBehaviour
{
    private static bool _is_player_contact;
    public static bool is_player_contact
    {
        set { _is_player_contact = value; }
        get { return _is_player_contact; }
    }
    // Start is called before the first frame update
    void Start()
    {
        _is_player_contact = false;
    }

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            _is_player_contact = true;
            //Debug.Log(_is_player_contact);
        }

    }
}
