using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinState : MonoBehaviour {

    public GameObject correctCard;
    public GameObject correctStone;
    public GameObject[] codeBlocks;

    public GameObject winImage;

    public AudioSource sounds;
    public AudioClip winSound;
    public GameObject performRitual;
    public Button ritualButton;
    //public AudioSource background;


    // Use this for initialization
    void Start () {
        sounds = GetComponent<AudioSource>();
        //background = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update () {
		if (correctCard.activeSelf == true && correctStone.activeSelf == true)
        {
            performRitual.SetActive(true);
            
            /*
            Debug.Log("Win");
            GetComponent<AudioSource>().clip = winSound;
            GetComponent<AudioSource>().Play();
            winImage.SetActive(true);
            //background.Stop();
            */
        }
	}

    public void GoToWin()
    {
        Debug.Log("Win");
        GetComponent<AudioSource>().clip = winSound;
        GetComponent<AudioSource>().Play();
        winImage.SetActive(true);
        //performRitual.SetActive(false);
    }

}
