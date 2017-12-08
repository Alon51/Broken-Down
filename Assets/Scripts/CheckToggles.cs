using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckToggles : MonoBehaviour {
    public Toggle manual;
    public Toggle gloves;
    public Toggle plank;
    public Toggle tire;
    public Toggle jack;
    public Toggle flashlight;
    public Toggle phone;
    public Toggle wrench;

    public GameObject correctCanvas;
    public GameObject incorrectCanvas;
    public GameObject thisCanvas;

    public void OnButtonClick() {
        int numCorrect = 0;

        if(manual.isOn) {
            numCorrect++;
        }
        if(tire.isOn) {
            numCorrect++;
        }
        if(jack.isOn) {
            numCorrect++;
        }
        if(wrench.isOn) {
            numCorrect++;
        }

        if(numCorrect == 4) {
            thisCanvas.SetActive(false);
            correctCanvas.SetActive(true);
        } else {
            thisCanvas.SetActive(false);
            incorrectCanvas.SetActive(true);
        }
    }
}
