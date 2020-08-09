using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FallOut : MonoBehaviour
{
    public int lives = 5;  //所持ライフ
    public Transform respawn; //Inspectorでrespawnを格納
    public Transform fallout;　//Inspectorでfalloutを格納
    public GameObject GameOverText;
    public Text HPLabel;
    // Start is called before the first frame update
    void Start()
    {
        GameOverText.SetActive(false);
        HPLabel.text = "HP:" + lives;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)　　//falloutにplayerがあたると
    {

        if (other.transform == fallout)
        {
            transform.position = respawn.position;   //playerがあたると respawnの位置へ移動
            lives -= 1; //ライフは１減る
            HPLabel.text = "HP:" + lives;
            if (lives==0)
            {
                GameOverText.SetActive(true);
            }
        }

    }
}
