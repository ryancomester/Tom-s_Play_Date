using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndScoreSys : MonoBehaviour
{
    /* takes value and saves it on PlayerPrefs.
     * the high score which is saved can be retried anytime through LoadScore().*/
       
    public static void SaveScore(int highScore)
    {
        PlayerPrefs.SetInt("highScore", highScore);
    }

    public static int LoadScore()
    {
        var _hS = PlayerPrefs.GetInt("highScore");
        return _hS;
    }
}
