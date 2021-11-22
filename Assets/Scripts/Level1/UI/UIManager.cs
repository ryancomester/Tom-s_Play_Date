using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI endScoreText;

    void Update()
    {
        if (PlayerManager.isGameStarted)
        {
            /* takes the current score and adds it to the GUI text*/
            scoreText.text = $"Score: {PlayerManager.numberOfBusicuts}";
        }

        if (PlayerManager.gameOver)
        {
            scoreText.text = "";
            endScoreText.text = $"Your Score is: {EndScoreSys.LoadScore()}";
        }
    }

    //UI manager

    public void Continue()
    {
        SceneManager.LoadScene("GiftPanel");
    }
}
