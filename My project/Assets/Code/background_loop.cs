using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background_loop : MonoBehaviour
{
    public float speed = 5;

    // Start is called before the first frame update
    void Start()
    {
 
    }

    // Update is called once per frame
    void background_move()
    {
       transform.Translate(Vector3.left * Time.deltaTime * speed);
        
        }
    }

