using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarotDeck : MonoBehaviour {

    [SerializeField]
    private Button tarotBox;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private GameObject tarotCardPanel;

    //sounds
    [SerializeField]
    private AudioSource sounds;
    [SerializeField]
    private AudioClip layerTone;

    //other items on table
    [SerializeField]
    private Button codeBookButton;
    [SerializeField]
    private Button alchemyBookButton;
    [SerializeField]
    private Button tarotBookButton;
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
