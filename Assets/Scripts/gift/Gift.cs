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
        if(endGameScore == 0)
        {
            textPanel.text = "Game Over";
            Destroy(gameObject);
        }
        else if (endGameScore <= 30)
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
            /*Orange*/
            GetComponent<MeshRenderer>().material.color = new Color(255, 120, 0);
        }
        else if (endGameScore <= 150)
        {
            textPanel.text = "get your cruncy rice craker on your way out.";
            /*greyish white*/
            GetComponent<MeshRenderer>().material.color = new Color(150, 162, 139);
        }
        else if (endGameScore <= 200)
        {
            textPanel.text = "get your cruncy chocolate cracker on your way out.";
            /*chocolate color*/
            GetComponent<MeshRenderer>().material.color = new Color(82, 37, 33);
        }
        else if (endGameScore <= 250)
        {
            textPanel.text = "get your cruncy strawberry puff on your way out.";
            /*pink color*/
            GetComponent<MeshRenderer>().material.color = new Color(169, 50, 142);
        }
        else
        {
            textPanel.text = "u are over the moon";
        }
    }

    void Update()
    {
        transform.Rotate(0, 0, 90 * Time.deltaTime);
    }
}
