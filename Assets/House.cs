using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // 回転、位置ともに固定
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeAll;


        // 回転しない設定
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezeRotation;


        // 移動しない設定
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePosition;


        // 位置 X だけ固定
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.FreezePositionX;
    }
}
