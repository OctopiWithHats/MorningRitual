using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyBook : MonoBehaviour {

    //GameObjects related to the alchemy book
    [SerializeField]
    private Button alchemyBook;
    [SerializeField]
    private GameObject openBook;
    [SerializeField]
    private GameObject[] pages;
    [SerializeField]
    private Button backButton;
    [SerializeField]
    private Button nextPage;
    [SerializeField]
    private Button prevPage;
    [SerializeField]
    private GameObject currentPage;
    [SerializeField]
    private int pageNumber;

    //audio for alchemy book
    [SerializeField]
    private AudioSource sounds;
    [SerializeField]
    public AudioClip pageTurn;
    [SerializeField]
    public AudioClip layerTone;

    //buttons for the other interactables
    [SerializeField]
    private Button codeBookButton;
    [SerializeField]
    public Button tarotBookButton;
    [SerializeField]
    public Button tarotDeckButton;
    [SerializeField]
    public Button alchemyBagButton;

    // Use this for initialization
    void Start () {
        pageNumber = 0;
        sounds = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
        currentPage = pages[pageNumber];
	}

    public void OnMouseOver()
    {
        Debug.Log("over alchemy book");
        //sounds.GetComponent<AudioSource>().clip = layerTone;
        //sounds.GetComponent<AudioSource>().Play();
    }

    public void OpenBook()
    {
        //open the alchemy book
        openBook.SetActive(true);
        //play the sounds for the alchemy book
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();

        //make sure that the player can't accidentally interact with anything else while the alchemy book is open
        codeBookButton.interactable = !codeBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void CloseBook()
    {
        //close the alchemy book
        openBook.SetActive(false);
        pageNumber = 0;
        
        //make other things on the table interactable again
        codeBookButton.interactable = !codeBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void NextPage()
    {
        //make sure we go to the correct page in the array of pages
        if (currentPage == pages[0])
        {
            pages[0].SetActive(false);
            pages[1].SetActive(true);
            pageNumber = 1;

        }
        else if (currentPage == pages[1])
        {
            pages[1].SetActive(false);
            pages[2].SetActive(true);
            pageNumber = 2;
        }
        else if (currentPage == pages[2])
        {
            pages[2].SetActive(false);
            pages[3].SetActive(true);
            pageNumber = 3;
        } 
        else if (currentPage == pages[3])
        {
            pages[3].SetActive(false);
            pages[0].SetActive(true);
            pageNumber = 0;
        }
    }

    public void PrevPage()
    {
        //make sure we go to the correct page in the array of pages
        if (currentPage == pages[1])
        {
            pages[1].SetActive(false);
            pages[0].SetActive(true);
            pageNumber = 0;
        }
        else if (currentPage == pages[2])
        {
            pages[2].SetActive(false);
            pages[1].SetActive(true);
            pageNumber = 1;
        }
        else if (currentPage == pages[3])
        {
            pages[3].SetActive(false);
            pages[2].SetActive(true);
            pageNumber = 2;
        }
        else if (currentPage == pages[0])
        {
            pages[0].SetActive(false);
            pages[3].SetActive(true);
            pageNumber = 3;
        }
    }
}
