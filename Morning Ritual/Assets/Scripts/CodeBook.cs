using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CodeBook : MonoBehaviour {

    //GameObejcts for code book
    [SerializeField]
    private Button codeBook;
    [SerializeField]
    private GameObject openBook;
    [SerializeField]
    private Button backButton;

    //sounds for code book
    [SerializeField]
    private AudioSource sounds;
    [SerializeField]
    private AudioClip pageTurn;
    [SerializeField]
    private AudioClip layerTone;

    //buttons for other interactables
    [SerializeField]
    private Button tarotBookButton;
    [SerializeField]
    private Button alchemyBookButton;
    [SerializeField]
    private Button tarotDeckButton;
    [SerializeField]
    private Button alchemyBagButton;

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
        //open the code book
        openBook.SetActive(true);
        //play code book sounds
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();

        //make other items uninteractable
        tarotBookButton.interactable = !tarotBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void CloseBook()
    {
        //close code book
        openBook.SetActive(false);
        
        //make other items interactable
        tarotBookButton.interactable = !tarotBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }
}
