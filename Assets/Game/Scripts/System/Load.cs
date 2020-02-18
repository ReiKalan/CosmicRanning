using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LOAD : MonoBehaviour
{
    public GameObject _obj;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Vector3 num = _obj.GetComponent<Save>()._hit_position;
            this.transform.position = num;
        }
        if (PositionInitialize.is_player_contact == true)
        {
            Vector3 num = _obj.GetComponent<Save>()._hit_position;
            this.transform.position = num;
            //Debug.Log(num);
        }

    }


}
