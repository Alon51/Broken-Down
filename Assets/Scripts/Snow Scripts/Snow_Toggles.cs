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

	//bool sequence = false;
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
			//sequence=1;
		}

	}

	public void Second(){
		if (traction.isOn && shovel.isOn && !dirt.isOn && !tire.isOn && !pedal.isOn && first) {
			second = true;
			//sequence=2;
		}
	}

	public void Third(){
		if (traction.isOn && shovel.isOn && dirt.isOn && !tire.isOn && !pedal.isOn && second) {
			third = true;
			//sequence=3;
		}
	}

	public void Fourth(){
		if (traction.isOn && shovel.isOn && dirt.isOn && tire.isOn && !pedal.isOn && third) {	
			fourth = true;
			//sequence=4;
		}
	}
	public void Fifth(){
		if (traction.isOn && shovel.isOn && dirt.isOn && tire.isOn && pedal.isOn && fourth) {
			fifth = true;
		}
	}

		/* else {

            //sequence = false;

            traction.isOn = false;
            shovel.isOn = false;
            dirt.isOn = false;
            tire.isOn = false;
            pedal.isOn = false;

			//first = false;
			//second = false;
			//third = false;
			//fourth = false;
			//fifth = false;

        }*/
    public void Submit()
    {
        //int sequence = 0;

        if (fifth == true)
        {
            scenarioCanvas.SetActive(false);
            snowCorrectCanvas.SetActive(true);
        }
        else
        {
			scenarioCanvas.SetActive (false);snowIncorrectCanvas.SetActive(true);
            //sequence = 0;
        }
    }
}
