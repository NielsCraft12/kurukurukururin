using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonToOtherScene : MonoBehaviour
{

    [SerializeField] private string nextSceneName;

    public void ToNextScene()
    {
        SceneManager.LoadScene(nextSceneName);
    }

    public void QuitGame()
    {
        Application.Quit();
    }



}
