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
  

    public GameObject snowCorrectCanvas;
    public GameObject snowIncorrectCanvas;
    public GameObject scenarioCanvas;

    public void OnButtonClick()
    {
        int sequence = 0;

        if (traction.isOn)
        {
            sequence++;
        }

        if (traction.isOn && shovel.isOn)
        {
            sequence++; ;
        }

        if (traction.isOn && shovel.isOn && dirt.isOn)
        {
            sequence++;
        }

        if (traction.isOn && shovel.isOn && dirt.isOn && tire.isOn)
        {
            sequence++;
        }

        if (traction.isOn && shovel.isOn && dirt.isOn && tire.isOn && pedal.isOn)
        {
            sequence++;
        }

        else {

            sequence = 0;

            traction.isOn = false;
            shovel.isOn = false;
            dirt.isOn = false;
            tire.isOn = false;
            pedal.isOn = false;

        }



        if (sequence == 5)
        {
            scenarioCanvas.SetActive(false);
            snowCorrectCanvas.SetActive(true);
        }
        else
        {
            scenarioCanvas.SetActive(false);
            snowIncorrectCanvas.SetActive(true);
            sequence = 0;
        }
    }
}
