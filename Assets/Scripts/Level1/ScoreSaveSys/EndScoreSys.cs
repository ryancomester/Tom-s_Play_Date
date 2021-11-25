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

    public static void SaveBgAudioPreference(bool _bgAudioPreference)
    {
        if(_bgAudioPreference)
            PlayerPrefs.SetInt("BackgroundAudio", 1);
        else
            PlayerPrefs.SetInt("BackgroundAudio", 0);
    }

    //Audio Preferences
    public static void SaveSFXPreference(bool _SFXPreference)
    {
        if (_SFXPreference)
            PlayerPrefs.SetInt("SFXAudio", 1);
        else
            PlayerPrefs.SetInt("SFXAudio", 0);

    }

    public static bool LoadBgAudioPreference()
    {
        int _val = PlayerPrefs.GetInt("BackgroundAudio");
        if (_val == 1)
            return true;
        else
            return false;
    }

    public static bool LoadSFXPreference()
    {
        int _val = PlayerPrefs.GetInt("SFXAudio");
        if (_val == 1)
            return true;
        else
            return false;
    }
}
