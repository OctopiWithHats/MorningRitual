using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyBag : MonoBehaviour {

    public Button alchemyBag;
    public Button backButton;
    public GameObject alchemyPanel;
    public AudioSource sounds;
    public AudioClip clothBag;
    public AudioClip layerTone;

    public Button codeBookButton;
    public Button alchemyBookButton;
    public Button tarotBookButton;
    public Button tarotDeckButton;

	// Use this for initialization
	void Start () {
        sounds = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnMouseOver()
    {
        Debug.Log("over alchemy bag");
       // sounds.GetComponent<AudioSource>().clip = layerTone;
       // sounds.GetComponent<AudioSource>().Play();
    }

    public void OpenBag()
    {
        alchemyPanel.SetActive(true);
        sounds.GetComponent<AudioSource>().clip = clothBag;
        sounds.GetComponent<AudioSource>().Play();

        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBag.interactable = !alchemyBag.interactable;
    }

    public void BackButton()
    {
        alchemyPanel.SetActive(false);

        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBag.interactable = !alchemyBag.interactable;

    }
}
