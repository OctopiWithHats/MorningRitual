using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyBag : MonoBehaviour {

    //Game objects for alchemy bag
    [SerializeField]
    private Button alchemyBag;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private GameObject alchemyPanel;

    //sounds for alchemy bag
    [SerializeField]
    private AudioSource sounds;
    [SerializeField]
    private AudioClip clothBag;
    [SerializeField]
    private AudioClip layerTone;

    //Game objects for books and decks
    [SerializeField]
    private Button codeBookButton;
    [SerializeField]
    private Button alchemyBookButton;
    [SerializeField]
    private Button tarotBookButton;
    [SerializeField]
    private Button tarotDeckButton;

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
        //show the alchemy panel, play the appropriate sounds
        alchemyPanel.SetActive(true);
        sounds.GetComponent<AudioSource>().clip = clothBag;
        sounds.GetComponent<AudioSource>().Play();

        //make sure that the player can't interact with the things behind the alchemy panel
        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBag.interactable = !alchemyBag.interactable;
    }

    public void BackButton()
    {
        //close the alchemy panel
        alchemyPanel.SetActive(false);

        //make other items interactable again
        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBag.interactable = !alchemyBag.interactable;

    }
}
