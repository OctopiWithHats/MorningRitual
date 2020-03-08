using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RitualPerform : MonoBehaviour {

    public Button correctCard;
    public Button correctStone;
    public Button[] otherCards;
    public Button[] otherStones;
    public GameObject ritualCard;
    public GameObject ritualStone;

    public AudioSource chimeSource;
    public AudioClip rightChime;
    public AudioClip wrongChime;

	// Use this for initialization
	void Start () {
        chimeSource = GetComponent < AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RitualCard()
    {
        ritualCard.SetActive(true);
        GetComponent<AudioSource>().clip = rightChime;
        GetComponent<AudioSource>().Play();
    }

    public void RitualStone()
    {
        ritualStone.SetActive(true);
        GetComponent<AudioSource>().clip = rightChime;
        GetComponent<AudioSource>().Play();
    }

    public void WrongChoice()
    {
        GetComponent<AudioSource>().clip = wrongChime;
        GetComponent<AudioSource>().Play();
    }

}
