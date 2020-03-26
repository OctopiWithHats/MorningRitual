using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DecodeCheck : MonoBehaviour {

    //game objects
    [SerializeField]
    private InputField codeBlank;
    [SerializeField]
    private string correctCharacter;
    [SerializeField]
    private string correctCharacter2;
    [SerializeField]
    private string inputText;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        CheckCode();
    }

    void CheckCode()
    {
        inputText = codeBlank.text;

        if (inputText == correctCharacter || inputText == correctCharacter2)
        {
            Debug.Log("Correct");
            codeBlank.interactable = !codeBlank.interactable;
        } else
        {
            Debug.Log("Incorrect");
        }
    }
}
