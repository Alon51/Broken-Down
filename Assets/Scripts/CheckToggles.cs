using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CheckToggles : MonoBehaviour {
	private int timesTried=0;
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
			GameControl.Instance.increaseScore (300 - (20 * timesTried));
            thisCanvas.SetActive(false);
            correctCanvas.SetActive(true);
        } else {
			timesTried++;
            thisCanvas.SetActive(false);
            incorrectCanvas.SetActive(true);
        }
    }
}
