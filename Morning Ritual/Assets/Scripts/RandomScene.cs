using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomScene : MonoBehaviour
{
    [SerializeField]
    private string[] sceneNames;

    private string chosenScene;

    // Start is called before the first frame update
    void Start()
    {
        chosenScene = sceneNames[Random.Range(0, sceneNames.Length)];
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene()
    {
        SceneManager.LoadScene(chosenScene);
    }


    static public void LoadSceneNamed(string name)
    {
        SceneManager.LoadScene(name);
    }
}
