using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AlchemyBook : MonoBehaviour {

    public Button alchemyBook;
    public GameObject openBook;
    public GameObject[] pages;
    public Button backButton;
    public Button nextPage;
    public Button prevPage;
    public GameObject currentPage;
    public int pageNumber;

    public AudioSource sounds;
    public AudioClip pageTurn;
    public AudioClip layerTone;

    public Button codeBookButton;
    public Button tarotBookButton;
    public Button tarotDeckButton;
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
        openBook.SetActive(true);
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();

        codeBookButton.interactable = !codeBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void CloseBook()
    {
        openBook.SetActive(false);
        pageNumber = 0;
        codeBookButton.interactable = !codeBookButton.interactable;
        tarotBookButton.interactable = !tarotBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void NextPage()
    {
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
