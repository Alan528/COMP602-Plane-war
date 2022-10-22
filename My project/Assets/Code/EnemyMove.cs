using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 2;

    public GameObject baozha;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed * Time.deltaTime, 0);
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
