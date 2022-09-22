using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManger : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] Enemy;
    void Start()
    {
        InvokeRepeating("SCEnemy", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SCEnemy()
    {
        int x = Random.Range(0, Enemy.Length);

        Instantiate(Enemy[x], new Vector3(Random.Range(1554f, 1566f), 443.34f, 0), Quaternion.identity);
    }
}
