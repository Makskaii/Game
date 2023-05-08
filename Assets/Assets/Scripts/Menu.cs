using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject menu;
    public GameObject selectLevelMenu;

    private bool on = true;
    private bool off = false;
    public void Play()
    {
        SceneManager.LoadScene(1); 
    }
    public void SelectLevel()
    {
        menu.SetActive(off);
        selectLevelMenu.SetActive(on);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void SelectLevel1()
    {
        SceneManager.LoadScene(1);
    }

    public void SelectLevel2()
    {
        SceneManager.LoadScene(2);
    }

    public void SelectLevel3()
    {
        SceneManager.LoadScene(3);
    }

    public void Back()
    {
        menu.SetActive(on);
        selectLevelMenu.SetActive(off);
    }

    public void ButtonMenu()
    {
        SceneManager.LoadScene(0);
    }
}
