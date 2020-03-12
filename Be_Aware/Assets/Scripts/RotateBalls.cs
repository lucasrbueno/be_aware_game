using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RotateBalls : MonoBehaviour
{
    public float speed;
    bool right;

    public GameObject gameOver;
    public int points;

    public Text text;
    public Text text2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            right = !right;
        }

        if (right == false)
        {
            transform.Rotate(new Vector3(0f, 0f, speed * Time.deltaTime));
        }
        else
        {
            transform.Rotate(new Vector3(0f, 0f, -speed * Time.deltaTime));
        }   
    }

    public void CallGameOver()
    {
        Time.timeScale = 0;
        gameOver.SetActive(true);
    }

    public void GameRestart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    public void RefreshPoints()
    {
        points++;
        text.text = points.ToString();
        text2.text = points.ToString();
    }
}
