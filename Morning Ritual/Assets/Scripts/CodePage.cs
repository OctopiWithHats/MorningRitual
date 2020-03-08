using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePage : MonoBehaviour {

    public Button openPage;
    public GameObject codePage;
    public Button closePage;

    public AudioSource sounds;
    public AudioClip pageTurn;
    public AudioClip layerTone;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseOver()
    {
      //  sounds.GetComponent<AudioSource>().clip = layerTone;
       // sounds.GetComponent<AudioSource>().Play();
    }

    public void OpenBook()
    {
        codePage.SetActive(true);
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();
        openPage.interactable = !openPage.interactable;
    }

    public void CloseBook()
    {
        codePage.SetActive(false);
        openPage.interactable = !openPage.interactable;
    }
}
