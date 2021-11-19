using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    public GameObject helpMenu;

    private void Start()
    {
        helpMenu.SetActive(false);
    }

    //takes user to the level1 where the game is.
    public void PlayGameBtn()
    {
        SceneManager.LoadScene("Level1");
    }

    public void helpMenuBtn()
    {
        helpMenu.SetActive(true);
    }

    public void helpExitBtn()
    {
        helpMenu.SetActive(false);
    }
}
