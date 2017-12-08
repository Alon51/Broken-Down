using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TireColor : MonoBehaviour {
    public Text tireText;
    public Toggle tireToggle;

    public void OnTireToggle() {
        if(tireToggle.isOn) {
            tireText.color = Color.green;
        } else {
            tireText.color = Color.red;
        }
    }
}