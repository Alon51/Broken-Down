using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WrenchColor : MonoBehaviour {
    public Text wrenchText;
    public Toggle wrenchToggle;

    public void OnWrenchToggle() {
        if(wrenchToggle.isOn) {
            wrenchText.color = Color.green;
        } else {
            wrenchText.color = Color.red;
        }
    }
}