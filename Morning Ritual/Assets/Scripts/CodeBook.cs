using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeBook : MonoBehaviour {

    public Button codeBook;
    public GameObject openBook;
    public Button backButton;

    public AudioSource sounds;
    public AudioClip pageTurn;
    public AudioClip layerTone;

    public Button tarotBookButton;
    public Button alchemyBookButton;
    public Button tarotDeckButton;
    public Button alchemyBagButton;

    // Use this for initialization
    void Start () {
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		
	}

    public void OnMouseOver()
    {
        Debug.Log("over code book");
       // sounds.GetComponent<AudioSource>().clip = layerTone;
       //sounds.GetComponent<AudioSource>().Play();
    }

    public void OpenBook()
    {
        openBook.SetActive(true);
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();

        tarotBookButton.interactable = !tarotBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void CloseBook()
    {
        openBook.SetActive(false);
        tarotBookButton.interactable = !tarotBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }
}
