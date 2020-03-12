using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject platformPrefab;

    public float time;
    public float minimum;
    public float maximum;
    public float totalTime;
    // Start is called before the first frame update
    void Start()
    {
        totalTime = Random.Range(minimum, maximum);
    }

    // Update is called once per frame
    void Update()
    {
        time = time + Time.deltaTime;

        if(time >= totalTime)
        {
            Instantiate(platformPrefab, transform.position, transform.rotation);
            totalTime = Random.Range(minimum, maximum);
            time = 0f;
        }
    }
}
