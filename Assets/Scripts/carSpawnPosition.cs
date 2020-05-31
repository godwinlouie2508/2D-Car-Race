using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carSpawnPosition : MonoBehaviour
{
    public GameObject[] cars;
    int carNo;
    public float maxPosition = 2.1f;
    public float delaytimer = 1f;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        timer = delaytimer;
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <=0)
        {
            Vector3 carPosition = new Vector3(Random.Range(-2.1f, 2.1f), transform.position.y, transform.position.z);

            carNo = Random.Range(0, 6);
            Instantiate(cars[carNo], carPosition, transform.rotation);

            timer = delaytimer;
        }
        
    }
}
