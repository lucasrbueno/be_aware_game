using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Balls : MonoBehaviour
{
    public RotateBalls rotateBalls;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Points")
        {
            Destroy(collision.gameObject);
            rotateBalls.RefreshPoints();
        }

        if (collision.gameObject.tag == "Platform")
        {
            rotateBalls.CallGameOver();
        }

    }
}
