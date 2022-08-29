using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    public float player_speed = 2;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    float x = Input.GetAxis ("Horizontal");
    float y = Input.GetAxis ("Vertical");

    transform.Translate (new Vector3(x*player_speed *Time.deltaTime, y*player_speed *Time.deltaTime, 0));
        
    }
}
