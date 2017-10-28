using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirPressureCheck : MonoBehaviour {
    public Text airPressureNumber;
    public GameObject correct;
    public GameObject incorrect;
   
    public void OnButtonClick() {
        if(airPressureNumber.text == "32") {
            correct.SetActive(true);
        } else {
            incorrect.SetActive(true);
        }
    }
}
