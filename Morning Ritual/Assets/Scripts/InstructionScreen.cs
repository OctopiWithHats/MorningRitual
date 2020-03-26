using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstructionScreen : MonoBehaviour {

    [SerializeField]
    private Button instructionButton;
    [SerializeField]
    private GameObject instructions;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GoToGame()
    {
        instructions.SetActive(false);
    }
}
