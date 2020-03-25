using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodePage : MonoBehaviour {

    //game objects for the code page
    [SerializeField]
    private Button openPage;
    [SerializeField]
    private GameObject codePage;
    [SerializeField]
    private Button closePage;

    //sounds for the code page
    [SerializeField]
    private AudioSource sounds;
    [SerializeField]
    private AudioClip pageTurn;
    [SerializeField]
    private AudioClip layerTone;

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
        //open the code page
        codePage.SetActive(true);
        
        //play the appropraiate sounds
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();

        //deactivate the open button
        openPage.interactable = !openPage.interactable;
    }

    public void CloseBook()
    {
        //close the page
        codePage.SetActive(false);

        //reactivate the open button
        openPage.interactable = !openPage.interactable;
    }
}
