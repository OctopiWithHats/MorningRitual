using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarotDeck : MonoBehaviour {

    public Button tarotBox;
    public Button backButton;
    public GameObject tarotCardPanel;

    public AudioSource sounds;
    public AudioClip layerTone;

    public Button codeBookButton;
    public Button alchemyBookButton;
    public Button tarotBookButton;
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
        Debug.Log("over tarot deck");
      //  sounds.GetComponent<AudioSource>().clip = layerTone;
       // sounds.GetComponent<AudioSource>().Play();
    }

    public void OpenTarot()
    {
        tarotCardPanel.SetActive(true);

        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void BackButton()
    {
        tarotCardPanel.SetActive(false);

        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }
}
