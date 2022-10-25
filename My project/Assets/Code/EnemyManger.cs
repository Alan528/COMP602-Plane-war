using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] Enemy;
    playerCtrl pc;

    void Start()
    {
        
        InvokeRepeating("SCEnemy", 1, 1);
        pc = GameObject.Find("Player").GetComponent<playerCtrl>();

    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SCEnemy()
    {
        int x = Random.Range(0, Enemy.Length);

        Instantiate(Enemy[x], new Vector3(Random.Range(1554f, 1566f), 443.34f, 0), Quaternion.identity);


        if (pc.score >= 4000){
            Instantiate(Enemy[x], new Vector3(Random.Range(1554f, 1566f), 443.34f, 0), Quaternion.identity);
        }
        if (pc.score >= 8000)
        {
            Instantiate(Enemy[x], new Vector3(Random.Range(1554f, 1566f), 443.34f, 0), Quaternion.identity);
        }
        if (pc.score >= 16000)
        {
            Instantiate(Enemy[x], new Vector3(Random.Range(1554f, 1566f), 443.34f, 0), Quaternion.identity);
        }
        if (pc.score >= 20000)
        {
            Application.LoadLevel("Winmenu");
        }
    }
}
