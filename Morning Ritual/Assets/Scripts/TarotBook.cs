using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TarotBook : MonoBehaviour {

    public Button tarotBook;
    public GameObject openBook;
    public GameObject[] pages;
    public Button backButton;
    public Button nextButton;
    public Button prevButton;
    public GameObject currentPage;
    public int pageNumber;

    public AudioSource sounds;
    public AudioClip pageTurn;
    public AudioClip layerTone;

    public Button codeBookButton;
    public Button alchemyBookButton;
    public Button tarotDeckButton;
    public Button alchemyBagButton;

	// Use this for initialization
	void Start () {
        pageNumber = 0;
        sounds = GetComponent<AudioSource>();
        //currentPage = pages[pageNumber];
	}
	
	// Update is called once per frame
	void Update () {
        currentPage = pages[pageNumber];
	}

    public void OnMouseOver()
    {
        Debug.Log("over tarot book");
        //sounds.GetComponent<AudioSource>().clip = layerTone;
        //sounds.GetComponent<AudioSource>().Play();
    }

    public void OpenBook()
    {
        openBook.SetActive(true);
        sounds.GetComponent<AudioSource>().clip = pageTurn;
        sounds.GetComponent<AudioSource>().Play();

        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
        tarotDeckButton.interactable = !tarotDeckButton.interactable;
        alchemyBagButton.interactable = !alchemyBagButton.interactable;
    }

    public void CloseBook()
    {
        openBook.SetActive(false);
        pageNumber = 0;

        codeBookButton.interactable = !codeBookButton.interactable;
        alchemyBookButton.interactable = !alchemyBookButton.interactable;
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
            
        } else if (currentPage == pages[1])
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
            pages[4].SetActive(true);
            pageNumber = 4;
        }
        else if (currentPage == pages[4])
        {
            pages[4].SetActive(false);
            pages[5].SetActive(true);
            pageNumber = 5;
        }
        else if (currentPage == pages[5])
        {
            pages[5].SetActive(false);
            pages[6].SetActive(true);
            pageNumber = 6;
        }
        else if (currentPage == pages[6])
        {
            pages[6].SetActive(false);
            pages[7].SetActive(true);
            pageNumber = 7;
        }
        else if (currentPage == pages[7])
        {
            pages[7].SetActive(false);
            pages[8].SetActive(true);
            pageNumber = 8;
        }
        else if (currentPage == pages[8])
        {
            pages[8].SetActive(false);
            pages[9].SetActive(true);
            pageNumber = 9;
        }
        else if (currentPage == pages[9])
        {
            pages[9].SetActive(false);
            pages[10].SetActive(true);
            pageNumber = 10;
        }
        else if (currentPage == pages[10])
        {
            pages[10].SetActive(false);
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
        else if (currentPage == pages[4])
        {
            pages[4].SetActive(false);
            pages[3].SetActive(true);
            pageNumber = 3;
        }
        else if (currentPage == pages[5])
        {
            pages[5].SetActive(false);
            pages[4].SetActive(true);
            pageNumber = 4;
        }
        else if (currentPage == pages[6])
        {
            pages[6].SetActive(false);
            pages[5].SetActive(true);
            pageNumber = 5;
        }
        else if (currentPage == pages[7])
        {
            pages[7].SetActive(false);
            pages[6].SetActive(true);
            pageNumber = 6;
        }
        else if (currentPage == pages[8])
        {
            pages[8].SetActive(false);
            pages[7].SetActive(true);
            pageNumber = 7;
        }
        else if (currentPage == pages[9])
        {
            pages[9].SetActive(false);
            pages[8].SetActive(true);
            pageNumber = 8;
        }
        else if (currentPage == pages[10])
        {
            pages[10].SetActive(false);
            pages[9].SetActive(true);
            pageNumber = 9;
        }
        else if (currentPage == pages[0])
        {
            pages[0].SetActive(false);
            pages[10].SetActive(true);
            pageNumber = 10;
        }
    }
}
