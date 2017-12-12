using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Snow_Toggles : MonoBehaviour {

    public Toggle traction;
    public Toggle shovel;
    public Toggle dirt;
    public Toggle tire;
    public Toggle pedal;

	public bool first = false;
	public bool second = false;
	public bool third = false;
	public bool fourth = false;
	public bool fifth = false;

    public GameObject snowCorrectCanvas;
    public GameObject snowIncorrectCanvas;
    public GameObject scenarioCanvas;


	public void First(){

		if (traction.isOn && !shovel.isOn && !dirt.isOn && !tire.isOn && !pedal.isOn) {
			first = true;
		}

	}

	public void Second(){
		if (traction.isOn && shovel.isOn && !dirt.isOn && !tire.isOn && !pedal.isOn && first) {
			second = true;
		}
	}

	public void Third(){
		if (traction.isOn && shovel.isOn && dirt.isOn && !tire.isOn && !pedal.isOn && second) {
			third = true;
		}
	}

	public void Fourth(){
		if (traction.isOn && shovel.isOn && dirt.isOn && tire.isOn && !pedal.isOn && third) {	
			fourth = true;
		}
	}
	public void Fifth(){
		if (traction.isOn && shovel.isOn && dirt.isOn && tire.isOn && pedal.isOn && fourth) {
			fifth = true;
		}
	}

    public void Submit()
    {
        if (fifth == true)
        {
            scenarioCanvas.SetActive(false);
            snowCorrectCanvas.SetActive(true);
        }
        else
        {
			scenarioCanvas.SetActive (false);snowIncorrectCanvas.SetActive(true);
			traction.isOn = false;
			shovel.isOn = false;
			dirt.isOn = false;
			tire.isOn = false;
			pedal.isOn = false;

			first = false;
			second = false;
			third = false;
			fourth = false;
			fifth = false;
            //sequence = 0;
        }
    }
}
