using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCtrl : MonoBehaviour
{
    // Start is called before the first frame update
    public float player_speed = 7;

    public GameObject zidan;
    public GUIStyle gs;

    public int score = 0;
    public int playerlife = 3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float x = Input.GetAxis ("Horizontal");
    float y = Input.GetAxis ("Vertical");

    transform.Translate (new Vector3(x*player_speed *Time.deltaTime, y*player_speed *Time.deltaTime, 0));

        if(Input.GetKeyUp(KeyCode.Space)){
            Instantiate(zidan, transform.position, Quaternion.identity);
        }
    }

    void OnGUI()
    {
        GUI.Label(new Rect(1200, 50, 200, 30), "Score" + score, gs);
        GUI.Label(new Rect(1200, 100, 200, 30), "Life" + playerlife, gs);
    }

  
}
