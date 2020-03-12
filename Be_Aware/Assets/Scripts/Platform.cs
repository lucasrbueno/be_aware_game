using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 10f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2(Mathf.PingPong(Time.time, 1), transform.localScale.y);

        transform.Translate(new Vector2(0f, speed * Time.deltaTime));
    }
}
