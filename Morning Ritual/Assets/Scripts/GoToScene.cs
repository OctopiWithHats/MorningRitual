using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoToScene : MonoBehaviour {

    public string sceneName;

    public void LoadScene()
    {

        SceneManager.LoadScene(sceneName);
    }


    static public void LoadSceneNamed(string name)
    {
        SceneManager.LoadScene(name);
    }
}
