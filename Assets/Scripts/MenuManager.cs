using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public static MenuManager Instance;
    public string TutorialVideoURL;
    private void Start()
    {
        Instance = this;
    }
    public void ExitApplication()
    {
        Application.Quit();
    }
    public void OpenTutorial()
    {
        Application.OpenURL(TutorialVideoURL);
    }
}
