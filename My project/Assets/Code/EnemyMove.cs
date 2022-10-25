using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour 
{
    // Start is called before the first frame update
    public float speed = 2;

    public int enemyLife;
   

    public GameObject baozha;
    playerCtrl pc;

    [Range(1, 4)]
    public int EnemyID;

    void Start()
    {
        pc = GameObject.Find("Player").GetComponent<playerCtrl>();
        if(EnemyID == 2)
        {
            enemyLife = 2;
        }
        if (EnemyID == 3)
        {
            enemyLife = 8;
        }
        if (EnemyID == 4)
        {
            enemyLife = 12;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < 426.00f)
        {
            Destroy(gameObject);
        }

    }




    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.transform.tag == "ZiDan")
        {
            enemyLife -= 2;
            if (enemyLife == 0)
            {
                Destroy(gameObject);
                Instantiate(baozha, transform.position, Quaternion.identity);

                if (EnemyID==2)
                {
                    pc.score += 100;
                }
                else if (EnemyID==3)
                {
                    pc.score += 200;
                }
                else if (EnemyID == 4)
                {
                    pc.score += 300;
                }

            }
            Destroy(col.gameObject);


        }
        if (col.transform.tag == "Player")
        {
            Destroy(gameObject);
            Instantiate(baozha, transform.position, Quaternion.identity);
            pc.playerlife -= 1;
            if (pc.playerlife == 0)
            {
                Application.LoadLevel("Died");
            }
        }
    }
}
