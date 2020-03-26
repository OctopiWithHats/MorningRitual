using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RitualPerform : MonoBehaviour {

    [SerializeField]
    private Button correctCard;
    [SerializeField]
    private Button correctStone;
    [SerializeField]
    private Button[] otherCards;
    [SerializeField]
    private Button[] otherStones;
    [SerializeField]
    private GameObject ritualCard;
    [SerializeField]
    private GameObject ritualStone;

    //sounds
    [SerializeField]
    private AudioSource chimeSource;
    [SerializeField]
    private AudioClip rightChime;
    [SerializeField]
    private AudioClip wrongChime;

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
