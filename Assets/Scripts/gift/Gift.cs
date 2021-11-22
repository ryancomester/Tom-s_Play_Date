using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Gift : MonoBehaviour
{
    public Text textPanel;
    public Text highScoreText;


    private int endGameScore;
    void Start()
    {
        Time.timeScale = 1;

        endGameScore = EndScoreSys.LoadScore();

        highScoreText.text = $"Your Score is {endGameScore}";

        Debug.Log(endGameScore);
        if (endGameScore <= 30)
        {
            textPanel.text = "get your cruncy cream puff on your way out.";
            GetComponent<MeshRenderer>().material.color = Color.yellow;
        }
        else if (endGameScore <= 70)
        {
            textPanel.text = "get your cruncy chilly puff on your way out.";
            GetComponent<MeshRenderer>().material.color = Color.red;
        } else if(endGameScore <= 100)
        {
            textPanel.text = "get your cruncy onion puff on your way out.";
            GetComponent<MeshRenderer>().material.color = Color.HSVToRGB(231, 135, 25);
        }
    }

    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }
}
