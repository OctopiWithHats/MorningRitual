using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneFade : MonoBehaviour
{
    //the fade image
    [SerializeField]
    private Image fadeImage;

    //the speed at which the image fades
    [SerializeField]
    private float fadeSpeed = 1.5f;

    //whether or not the scene is starting
    [SerializeField]
    private bool sceneStarting = true;

    //Title scene
    [SerializeField]
    private string sceneName;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //Call StartScene() if the scene is starting
        if (sceneStarting)
            StartScene();
    }

    void FadeToClear()
    {
        //lerp image to transparent
        fadeImage.color = Color.Lerp(fadeImage.color, Color.clear, fadeSpeed * Time.deltaTime);
    }

    /*
    void FadeToBlack()
    {
        //lerp image to black
        fadeImage.color = Color.Lerp(fadeImage.color, Color.black, fadeSpeed * Time.deltaTime);
    }
    */

    void StartScene()
    {
        // Fade the texture to clear.
        FadeToClear();

        // when almost transparent, set to transparent and disable image
        if (fadeImage.color.a <= 0.05f)
        {
            fadeImage.color = Color.clear;
            fadeImage.enabled = false;

            // The scene is no longer starting.
            sceneStarting = false;
        }
    }

    /*
    public IEnumerator EndSceneRoutine(string sceneName)
    {
        // Make sure the image is enabled.
        fadeImage.enabled = true;
        do
        {
            // Start fading towards black.
            FadeToBlack();

            //if image is almost black, go to correct scene
            if (fadeImage.color.a >= 0.95f)
            {
                SceneManager.LoadScene(sceneName);
                yield break;
            }
            else
            {
                yield return null;
            }
        } while (true);
    }

    public void EndScene(string sceneName)
    {
        sceneStarting = false;
        StartCoroutine("EndSceneRoutine", sceneName);
    }
    */
}
