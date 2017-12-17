using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirPressureCheck : MonoBehaviour {
    public Text airPressureNumber;
    public GameObject correct;
    public GameObject incorrect;
	private int timesTried=0;
   
    public void OnButtonClick() {
        if(airPressureNumber.text == "32") {
			GameControl.Instance.increaseScore(100 - (timesTried * 5));
            correct.SetActive(true);
        } else {
			timesTried++;
            incorrect.SetActive(true);
        }
    }
}
