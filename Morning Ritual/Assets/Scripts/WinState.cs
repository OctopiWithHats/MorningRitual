﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinState : MonoBehaviour {

    [SerializeField]
    private GameObject correctCard;
    [SerializeField]
    private GameObject correctStone;
    [SerializeField]
    private GameObject[] codeBlocks;

    [SerializeField]
    private GameObject winImage;

    [SerializeField]
    private AudioSource sounds;
    [SerializeField]
    private AudioClip winSound;
    [SerializeField]
    private GameObject performRitual;
    [SerializeField]
    private Button ritualButton;

    /*
    //winImage for lerp
    [SerializeField]
    private Image winPicture;

    //fade speed for lerping in image
    [SerializeField]
    private float fadeSpeed = 1.5f;
    */

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
        //FadeInImage();
    }

    /*
    void FadeInImage()
    {
        //lerp image to opaque
        winPicture.color = Color.Lerp(winPicture.color, Color.black, fadeSpeed * Time.deltaTime);
    }
    */

}
