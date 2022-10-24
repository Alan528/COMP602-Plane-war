using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;

    public GameObject baozha;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "ZiDan")
        {
            Destroy (gameObject);
            Instantiate(baozha, transform.position, Quaternion.identity);
            Destroy (col.gameObject);
        }
    }
}
