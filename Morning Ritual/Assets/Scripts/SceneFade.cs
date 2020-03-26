using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SceneFade : MonoBehaviour
{
    [SerializeField]
    private Image fadeImage;

    private CanvasRenderer fi;

    // Start is called before the first frame update
    void Start()
    {
        fi = fadeImage.GetComponent<CanvasRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeIn()
    {
        fi.SetAlpha(0.0f);

        fi.SetAlpha(Mathf.Lerp(0.0f, 1.0f, 2.0f));

    }

    public void FadeOut()
    {
        fi.SetAlpha(1.0f);

        fi.SetAlpha(Mathf.Lerp(1.0f, 0.0f, 2.0f));
    }
}
